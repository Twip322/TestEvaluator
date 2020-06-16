using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseImplemention.Models
{
    public class TestQuestions
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public int QuestionId { get; set; }
        public string questName { get; set; }
        public string answers { get; set; }
        public int rightNum { get; set; }
        public virtual Tests tests { get; set; }
        public virtual Questions questions{ get; set; }
    }
}
