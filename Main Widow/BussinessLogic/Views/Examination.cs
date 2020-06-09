using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Views
{
    public class Examination
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public Dictionary<Examination,int> examinations { get; set; }
        Student student { get; set; }
    }
}
