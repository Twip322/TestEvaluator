using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBaseImplemention.Models
{
    public class Tests
    {
        public int Id { get; set; }
        public string testName { get; set; }
        public virtual List<TestQuestions> testQuestionss { get; set; }

    }
}
