using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBaseImplemention.Models
{
    public class Test
    {
        public int Id { get; set; }
            
        [ForeignKey("questionId")]
        public virtual List<Question> Questions { get; set; }

    }
}
