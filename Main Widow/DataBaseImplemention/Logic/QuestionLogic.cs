using BusinessLogic.BindingModels;
using BusinessLogic.Views;
using DataBaseImplemention.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBaseImplemention.Logic
{
    public class QuestionLogic
    {
        public void CreateOrUpdate(QuestionBindModel model)
        {
            using (var context = new DataBase())
            {
                Questions element = context.Questions.FirstOrDefault(rec =>
               rec.quest == model.quest && rec.Id != model.Id);
                if (model.Id.HasValue)
                {
                    element = context.Questions.FirstOrDefault(rec => rec.Id ==
                   model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Questions();
                    context.Questions.Add(element);
                }
                element.quest = model.quest;
                element.ansewrs = model.answers;
                element.rightNum = model.rightNum;
                context.SaveChanges();
            }
        }
        public List<Question> Read(QuestionBindModel model)
        {
            using (var context = new DataBase())
            {
                return context.Questions
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new Question
                {
                    Id = rec.Id,
                    quest=rec.quest,
                    answers = rec.ansewrs,
                    rightNum=rec.rightNum
                })
                .ToList();
            }
        }
    }
}
