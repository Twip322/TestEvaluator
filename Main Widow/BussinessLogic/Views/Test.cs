using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Views
{
    public class Test
    {
        public int? Id { get; set; }
        public int testNum { get; set; }
        List<Question> questions { get; set; }

        Student student { get; set; }
    }
}
