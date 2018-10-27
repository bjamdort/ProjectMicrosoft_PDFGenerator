using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_Report_Generator
{
    class Question
    {
        public string Description { get; set; }

        public List<Answer> Answer = new List<Answer>();

    }
}
