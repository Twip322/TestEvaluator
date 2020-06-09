using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Views
{
    public class Examiner
    {
        public int? Id { get; set; }
        public DateTime date { get; set; }
        
        public string examName { get; set; }

       public Dictionary<int,int> examinations { get; set; }
    }
}
