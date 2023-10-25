using exam.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace exam.Classes
{
    public static class Paths
    {
        public static readonly string appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public static readonly string multiplyChoiceQuestionPath = Path.Combine(appDir, @"Questions\multiplyChoiceQuestion.txt");
        public static readonly string oneChoiceQuestionPath = Path.Combine(appDir, @"Questions\oneChoiceQuestion.txt");
        public static readonly string textQuestionPath = Path.Combine(appDir, @"Questions\textQuestion.txt");

        public static readonly string timePath = Path.Combine(appDir, @"Questions\time.txt");
    }
}
