using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Views
{
    public class Student
    {
        public int? Id { get; set; }

        public string name { get; set; }
        public Dictionary<int,int> tests { get; set; }
        public Dictionary<int,int> examinations { get; set; }
    }
}
