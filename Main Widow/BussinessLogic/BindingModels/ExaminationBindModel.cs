using BusinessLogic.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModels
{
    public class ExaminationBindModel
    {
        public int? Id { get; set; }

        public DateTime date { get; set; }

        public string examName { get; set; }
    }
}
