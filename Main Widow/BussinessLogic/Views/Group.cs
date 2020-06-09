using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Views
{
    public class Group
    {
        public int? Id { get; set; }
        public string groupName { get; set; }
        List<Student> students { get; set; }
    }
}
