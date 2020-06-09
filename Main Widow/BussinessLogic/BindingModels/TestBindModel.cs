using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModels
{
    public class TestBindModel
    {
        public int? Id { get; set; }
        public int testNum { get; set; }
        public Dictionary<int,int> questions { get; set; }
    }
}
