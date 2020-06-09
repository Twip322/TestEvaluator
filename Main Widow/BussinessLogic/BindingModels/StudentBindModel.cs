using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModels
{
    public class StudentBindModel
    {
        public int? Id { get; set; }
        public string name { get; set; }

        public Dictionary<int,int> mustexams { get; set; }
        public Dictionary<int,int> inGroup { get; set; }
        public Dictionary<int,int> mustTests { get; set; }
    }
}
