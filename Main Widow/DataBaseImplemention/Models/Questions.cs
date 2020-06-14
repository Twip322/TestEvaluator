using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBaseImplemention.Models
{
    public class Questions
    {
        public int Id { get; set; }
        public string quest { get; set; }
        public string ansewrs { get; set; }
        public int rightNum { get; set; }
        [ForeignKey("QuestID")]
        public virtual List<TestQuestions> Testquests { get; set; }
    }
}
