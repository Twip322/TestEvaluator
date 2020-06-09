using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModels
{
    public class ExaminerBindModel
    {
        public int? Id { get; set; }

        public string Name { get; set; }
        public Dictionary<int,int> examinations { get; set; }
    }
}
