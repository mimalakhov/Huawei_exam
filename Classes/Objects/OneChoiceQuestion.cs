using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace exam.Objects
{
    internal class OneChoiceQuestion : Question, IQuestionable
    {
        public List<Variant> variants;
        public string userAnswer;

        public OneChoiceQuestion(string formulation, List<Variant> variants, string userAnswer)
            : base(formulation)
        {
            this.variants = variants;
            this.userAnswer = userAnswer;
        }

        public bool isCorrect()
        {
            if (userAnswer != null)
                return (this.correctAnswer() == userAnswer);
            return false;
        }

        public string getUserAnswer()
        {
            if (this.userAnswer == null) return "";
            else return this.userAnswer;
        }

        public string showCorrectAnswer(int number)
        {
            string result = String.Format("{0}. {1}\r\n", number.ToString(), formulation);
            result += String.Format("Ответ: {0}\r\n", correctAnswer());
            result += "Ваш ответ правильный\r\n";
            result += "\r\n";
            return result;
        }

        public string showUncorrectAnswer(int number)
        {
            string result = String.Format("{0}. {1}\r\n", number.ToString(), formulation);
            result += String.Format("Ваш ответ: {0}\r\n", getUserAnswer());
            result += String.Format("Правильный ответ: {0}\r\n", correctAnswer());
            result += "Ваш ответ неправильный\r\n";
            result += "\r\n";
            return result;
        }

        public string correctAnswer()
        {
            return this.variants.First(variant => variant.isCorrect).answer;
        }

        public static List<OneChoiceQuestion> readInFile(string path, bool isForDeleting)
        {
            List<OneChoiceQuestion> result = new List<OneChoiceQuestion>();

            string[] lines = File.ReadAllLines(path);
            for (int j = 0; j < lines.Length; j++)
            {
                if (isForDeleting)
                    lines[j] = lines[j].Replace("#", "(Заблокировано)");
                else if (lines[j].Substring(0, 1) == "#")
                    continue;

                string[] words = lines[j].Split('|');

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

                result.Add(new OneChoiceQuestion(formulation, variants, null));
            }

            return result;
        }

        public string writeInFile(string path)
        {
            string result = this.formulation + " ";

            foreach (var variant in this.variants)
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
