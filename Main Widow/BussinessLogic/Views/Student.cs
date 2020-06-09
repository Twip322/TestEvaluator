using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Views
{
    public class Student
    {
        public int? Id { get; set; }

        public string name { get; set; }

        Group group { get; set; }
        List<Test> tests { get; set; }
        List<Examination> examinations { get; set; }
    }
}
