using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.Objects
{
    internal class Variant
    {
        public string answer;
        public bool isCorrect;

        public Variant(string answer, bool isCorrect)
        {
            this.answer = answer;
            this.isCorrect = isCorrect;
        }

    }
}
