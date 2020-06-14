using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BusinessLogic.Views
{
    public class Examiner
    {
        public int Id { get; set; }

        [DisplayName ("Фамилия Преподавателя")]
        public string examinerName { get; set; }
    }
}
