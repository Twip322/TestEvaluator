using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Views
{
    public class Test
    {
        public int? Id { get; set; }
        public string testName { get; set; }
        public Dictionary<int,(string,int)> testQuestions { get;set; }
    }
}
