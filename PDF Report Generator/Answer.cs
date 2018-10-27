using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_Report_Generator
{
    class Answer
    {
        public string Explanation { get; set; }
        public int Score { get; set; }
        public int Inspector { get; set; }

        public Answer(string Explanation, int Score, int Inspector)
        {
            this.Explanation = Explanation;
            this.Score = Score;
            this.Inspector = Inspector;
        }
    }
}
