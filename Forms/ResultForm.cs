using exam.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace exam
{
    public partial class ResultForm : Form
    {
        const int percentageMin = 30;
        const int multiplier = 1;

        List<IQuestionable> allQuestions;

        private int rigthQuestionCount;
        private int questionCount;

        private string textRapport;

        private bool passOrFail;

        public ResultForm(List<IQuestionable> listQuestions)
        {
            InitializeComponent();
            this.allQuestions = listQuestions;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            // Демонстрируем отчёт о пройденном экзамене
            this.textRapport = rapport();

            // Заполняем поля количества правильных ответов
            // и процента прохождения
            fillRightQuestion();
            
            // Отображаем результат по проценту
            sayResult();
        }

        /* Формирует отчёт о правильных/неправильных ответах и ведёт
         их подсчёт*/
        private string rapport()
        {
            string result = "";
            this.questionCount = 0;
            this.rigthQuestionCount = 0;
            foreach(IQuestionable question in allQuestions)
            {
                this.questionCount++;
                if (question is TextQuestion)
                {
                    TextQuestion textQuestion = (TextQuestion)question;
                    if (textQuestion.isCorrect()) 
                    {
                        string text = textQuestion.showCorrectAnswer(this.questionCount);
                        rapportTextBox.Text += text;
                        result += text;
                        this.rigthQuestionCount++;
                    }
                    else
                    {
                        string text = textQuestion.showUncorrectAnswer(this.questionCount);
                        rapportTextBox.Text += text;
                        result += text;
                    }
                }
                if (question is OneChoiceQuestion)
                {
                    OneChoiceQuestion oneChoiceQuestion = (OneChoiceQuestion)question;
                    if (oneChoiceQuestion.isCorrect())
                    {
                        string text = oneChoiceQuestion.showCorrectAnswer(this.questionCount);
                        rapportTextBox.Text += text;
                        result += text;
                        this.rigthQuestionCount++;
                    }
                    else
                    {
                        string text = oneChoiceQuestion.showUncorrectAnswer(this.questionCount);
                        rapportTextBox.Text += text;
                        result += text;
                    }
                }
                if (question is MultiplyChoiceQuestion)
                {
                    MultiplyChoiceQuestion multiplyChoiceQuestion = (MultiplyChoiceQuestion)question;
                    if (multiplyChoiceQuestion.isCorrect())
                    {
                        string text = multiplyChoiceQuestion.showCorrectAnswer(this.questionCount);
                        rapportTextBox.Text += text;
                        result += text;
                        this.rigthQuestionCount++;
                    }
                    else
                    {
                        string text = multiplyChoiceQuestion.showUncorrectAnswer(this.questionCount);
                        rapportTextBox.Text += text;
                        result += text;
                    }
                }
            }
            return result;
        }

        private void fillRightQuestion()
        {
            numberOfPointsLabel.Text = numRight();
            percentageLabel.Text = perRight().ToString();
        }

        private string numRight()
        {
            return 
                this.rigthQuestionCount * multiplier + "/" + this.questionCount * multiplier;
        }

        private double perRight()
        {
            return ((double)this.rigthQuestionCount / (double)this.questionCount) * 100;
        }

        private void sayResult()
        {
            double percentage = perRight();

            string appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string pathImage = @"Results\pass1.jpg";
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            if (percentage > percentageMin)
            {
                passOrFailLabel.ForeColor = Color.Green;
                passOrFailLabel.Text = "Поздравляем! Вы сдали экзамен!";
                this.passOrFail = true;
            }
            else
            {
                passOrFailLabel.ForeColor = Color.Red;
                passOrFailLabel.Text = "К сожалению, Вы не сдали экзамен...";
                pathImage = @"Results\fail.jpg";
                this.passOrFail = false;
            }

            string path = Path.Combine(appDir, pathImage);
            pictureBox.Image = Image.FromFile(path);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == null || nameTextBox.Text == "")
            {
                MessageBox.Show("Не введено имя!", "Ошибка");
                return;
            }
            string path = "";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Сохранить как...";
            saveFileDialog.Filter = "Text files(*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
            }

            string textFileRapport = "Имя: " + nameTextBox.Text + "\r\n";
            textFileRapport += "Дата: " + DateTime.Now.ToString() + "\r\n\r\n";
            textFileRapport += "Количество баллов: " + numRight() + "\r\n";
            textFileRapport += "Процент прохождения: " + perRight() + "\r\n";
            if (this.passOrFail) textFileRapport += "Результат: сдал";
            else textFileRapport += "Результат: не сдал";
            textFileRapport += "\r\n\r\n";
            textFileRapport += this.textRapport;

            if (path != null && path.Length != 0)
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(textFileRapport);
            }
        }

        private void ResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
