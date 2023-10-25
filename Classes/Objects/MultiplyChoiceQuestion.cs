using exam.Helper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace exam.Objects
{
    internal class MultiplyChoiceQuestion : Question, IQuestionable
    {
        public List<Variant> variants;
        public List<string> userAnswers;

        public MultiplyChoiceQuestion(string formulation, List<Variant> variants, List<string> userAnswers)
            : base(formulation)
        {
            this.variants = variants;
            this.userAnswers = userAnswers;
        }

        public bool isCorrect()
        {
            if (this.userAnswers == null || this.userAnswers.Count == 0) return false;
            bool correct = true;
            var rightVariants = this.variants.Where(variant => variant.isCorrect);
            foreach(var variant in rightVariants)
            {
                correct = correct && this.userAnswers.Contains(variant.answer);
            }
            if (rightVariants.Count() == this.userAnswers.Count) return correct;
            else return false;
        }

        public string correctAnswersString()
        {
            string result = "";
            var rightVariants = this.variants.
                                    Where(variant => variant.isCorrect).
                                    Select(variant1 => variant1.answer);
            foreach (var variant in rightVariants)
            {
                result += String.Format("-- {0}\r\n", variant);
            }
            if (result == null || result.Length == 0) return result;
            else return result.Substring(0, result.Length - 2);
        }

        public string userAnswerString()
        {
            string result = "";
            if (this.userAnswers != null)
            {
                foreach (var variant in this.userAnswers)
                {
                    result += String.Format("-- {0}\r\n", variant);
                }
                if (result == null || result.Length == 0) return result;
                else return result.Substring(0, result.Length - 2);
            }
            return result;
        }

        public string showCorrectAnswer(int number)
        {
            string result = String.Format("{0}. {1}\r\n", number.ToString(), formulation);
            result += String.Format("Ответ: \r\n{0}\r\n", correctAnswersString());
            result += "Ваш ответ правильный\r\n";
            result += "\r\n";
            return result;
        }

        public string showUncorrectAnswer(int number)
        {
            string result = String.Format("{0}. {1}\r\n", number.ToString(), formulation);
            result += String.Format("Ваш ответ: {0}\r\n", userAnswerString());
            result += String.Format("Правильный ответ: {0}\r\n", correctAnswersString());
            result += "Ваш ответ неправильный\r\n";
            result += "\r\n";
            return result;
        }

        public static List<MultiplyChoiceQuestion> readInFile(string path, bool isForDeleting)
        {
            List<MultiplyChoiceQuestion> result = new List<MultiplyChoiceQuestion>();

            string[] lines = File.ReadAllLines(path);
            for (int j = 0; j < lines.Length; j++)
            {
                if (isForDeleting)
                    lines[j] = lines[j].Replace("#", "(Заблокировано)");
                else if (lines[j].Substring(0, 1) == "#")
                    continue;

                string[] words = lines[j].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                string formulation = words[0].Trim();
                List<Variant> variants = new List<Variant>();

                for (int i = 1; i < words.Length; i++)
                {
                    if (words[i].Trim().Substring(0, 1) == "!")
                        variants.Add(
                            new Variant(
                                words[i].Substring(1, words[i].Length - 1).Trim(),
                                true
                               )
                            );
                    else
                        variants.Add(
                            new Variant(
                                words[i].Trim(),
                                false
                               )
                            );
                }

                result.Add(new MultiplyChoiceQuestion(formulation, variants, null));
            }

            return result;
        }

        public string writeInFile(string path)
        {
            string result = this.formulation + " ";

            foreach(var variant in this.variants)
            {
                if (variant.isCorrect)
                    result += "|! " + variant.answer + " ";
                else
                    result += "| " + variant.answer + " ";
            }

            if (path == null) return result;

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(result);
            }

            return result;
        }

    }
}
