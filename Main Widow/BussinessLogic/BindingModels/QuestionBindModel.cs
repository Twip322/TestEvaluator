﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModels
{
    public class QuestionBindModel
    {
        public int? Id { get; set; }
        public string quest { get; set; }
        public string answers { get; set; }
        public int rightNum { get; set; }
    }
}
