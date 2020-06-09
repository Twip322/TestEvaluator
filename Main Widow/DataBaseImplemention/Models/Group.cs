using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBaseImplemention.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string groupName { get; set; }

        [ForeignKey("studentId")]
        public virtual List<Student> Students { get; set; }
    }
}
