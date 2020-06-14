﻿using BusinessLogic.BindingModels;
using BusinessLogic.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBaseImplemention.Logic
{
    public class ExaminerLogic
    {   
        public List<Examiner> Read(ExaminerBindModel model)
        {
            using (var context = new DataBase())
            {
                return context.Examiners
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new Examiner
                {
                    Id = rec.Id,
                    examinerName = rec.examinerName
                })
                .ToList();
            }
        }
    }
}
