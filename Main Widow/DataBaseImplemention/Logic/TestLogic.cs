using BusinessLogic.BindingModels;
using BusinessLogic.Views;
using DataBaseImplemention.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBaseImplemention.Logic
{
    public class TestLogic
    {
        public void CreateOrUpdate(TestBindModel model)
        {
            using (var context = new DataBase())
            {
                using (var transaction = context.Database.BeginTransaction()) {
                    try
                    {
                        Tests element = context.Tests.FirstOrDefault(rec =>
                       rec.testName == model.testName && rec.Id != model.Id);
                        if (element != null)
                        {
                            throw new Exception("Уже есть компонент с таким названием");
                        }
                        if (model.Id.HasValue)
                        {
                            element = context.Tests.FirstOrDefault(rec => rec.Id ==
                           model.Id);
                            if (element == null)
                            {
                                throw new Exception("Элемент не найден");
                            }
                        }
                        else
                        {
                            element = new Tests();
                            context.Tests.Add(element);
                        }
                        element.testName = model.testName;
                        context.SaveChanges();
                        if (model.Id.HasValue)
                        {
                            var Testquestions = context.TestsQuestions.Where(rec
                           => rec.QuestionId == model.Id.Value).ToList();
                            // удалили те, которых нет в модели
                            context.TestsQuestions.RemoveRange(Testquestions.Where(rec =>
                            !model.testQuestions.ContainsKey(rec.QuestionId)).ToList());
                            context.SaveChanges();
                            // обновили количество у существующих записей
                            foreach (var updateQuestions in Testquestions)
                            {
                                model.testQuestions.Remove(updateQuestions.QuestionId);
                            }
                            context.SaveChanges();
                        }

                        // добавили новые
                        foreach (var questions in model.testQuestions)
                        {
                            context.TestsQuestions.Add(new TestQuestions
                            {
                                TestId = element.Id,
                                QuestionId = questions.Key,
                            });
                            context.SaveChanges();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;

                    }
                }
            }
        }
    

        public List<Test> Read(TestBindModel model)
        {
            using (var context = new DataBase())
            {
                return context.Tests
                .Where(rec => model == null || rec.Id == model.Id)
                .ToList()
                .Select(rec => new Test
                {
                    Id = rec.Id,
                   testQuestions=context.TestsQuestions
                   .Include(recPC => recPC.questions)
                   .Where(recPC => recPC.TestId == rec.Id)
                .ToDictionary(recPC => recPC.QuestionId, recPC =>
                (recPC.questions.quest,recPC.questions.ansewrs,recPC.questions.rightNum))
                })
                .ToList();
            }
        }
    }
}
