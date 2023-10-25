using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace exam.Objects
{
    internal class TextQuestion : Question, IQuestionable
    {
        public string answer;
        public string userAnswer;

        public TextQuestion(string formulation, string answer) 
            : base(formulation)
        {
            this.answer = answer;
        }

        public bool isCorrect()
        {
            if (this.answer == this.userAnswer) return true;
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
            result += String.Format("Ответ: {0}\r\n", answer);
            result += "Ваш ответ правильный\r\n";
            result += "\r\n";
            return result;
        }

        public string showUncorrectAnswer(int number)
        {
            string result = String.Format("{0}. {1}\r\n", number.ToString(), formulation);
            result += String.Format("Ваш ответ: {0}\r\n", getUserAnswer());
            result += String.Format("Правильный ответ: {0}\r\n", answer);
            result += "Ваш ответ неправильный\r\n";
            result += "\r\n";
            return result;
        }

        public static List<TextQuestion> readInFile(string path, bool isForDeleting)
        {
            List<TextQuestion> result = new List<TextQuestion>();

            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                if (isForDeleting)
                    lines[i] = lines[i].Replace("#", "(Заблокировано)");
                else if (lines[i].Substring(0, 1) == "#")
                    continue;

                string[] words = lines[i].Split('|');

                result.Add(
                    new TextQuestion(
                        words[0].Trim(),
                        words[1].Trim()
                        )
                );
            }
            return result;
        }
        
        public string writeInFile(string path)
        {
            string result = this.formulation + " | " + this.answer;

            if (path == null) return result;

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(result);
            }

            return result;
        }

    }
}
