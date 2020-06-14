using BusinessLogic.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModels
{
    public class TestBindModel
    {
        public int? Id { get; set; }
        public string testName { get; set; }
        public Dictionary<int, (string, int)> testQuestions { get; set; }
    }
}
