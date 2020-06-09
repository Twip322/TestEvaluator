using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBaseImplemention.Models
{
    public class Examiner
    {
        public int Id { get; set; }
        public string name { get; set; }
        [ForeignKey("examNameId")]
        public virtual List<Examination> Examinations { get; set; }
    }
}
