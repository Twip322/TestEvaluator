using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBaseImplemention.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string name { get; set; }
        public virtual Group Groups { get; set; }
        [ForeignKey("examinationID")]
        public virtual List<Examination> Examinations { get; set; }
        [ForeignKey("testID")]
        public virtual List<Test> Tests { get; set; }
    }
}
