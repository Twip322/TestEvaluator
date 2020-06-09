using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseImplemention.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string quest { get; set; }
        public string answer { get; set; }

        public virtual Test Test { get; set; }
    }
}
