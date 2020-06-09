using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseImplemention.Models
{
    public class Examination
    {
        public int Id { get; set; }
        public string examName { get; set; }

        public virtual Examiner examiners { get; set; }
    }
}
