using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBaseImplemention.Models
{
    public class Examiners
    {
        public int Id { get; set; }
        public string examinerName { get; set; }
        public virtual Tests Test { get; set; }
    }
}
