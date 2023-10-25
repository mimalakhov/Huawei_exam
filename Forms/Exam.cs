using exam.Classes;
using exam.Helper;
using exam.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class Exam : Form
    {
        const int xStart = 12;
        const int yStart = 149;
        const int gap = 10;

        DateTime checkTime;

        Stack <IQuestionable> left;
        IQuestionable current;
        Stack<IQuestionable> right;

        int counterQuestions = 1;

        GroupBox userAnswers;

        public Exam()
        {
            InitializeComponent();

            this.left = new Stack<IQuestionable>();
            this.right = new Stack<IQuestionable>();

            this.userAnswers = new GroupBox();
            this.userAnswers.Location = new Point(xStart, yStart);
            this.userAnswers.Size = new Size(530, 200);
            this.userAnswers.Text = "Ваш ответ?";

            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();
            timer.Tick += timer_Tick;
        }

        private void Exam_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.userAnswers);

            // Инициализация таймера
            int hourExtend = ReadDate.readDateHour(Paths.timePath);
            int minuteExtend = ReadDate.readDateMinute(Paths.timePath);

            this.checkTime = DateTime.Now.
                            AddHours(hourExtend).
                            AddMinutes(minuteExtend);

            if (!File.Exists(Paths.multiplyChoiceQuestionPath) || !File.Exists(Paths.oneChoiceQuestionPath) || !File.Exists(Paths.textQuestionPath))
            {
                this.Close();
                MessageBox.Show("Нет файла!");
            }

            // Слияние всех вопросов в одну коллекцию и перемешивание
            var list1 = MultiplyChoiceQuestion.readInFile(Paths.multiplyChoiceQuestionPath, false);
            var list2 = OneChoiceQuestion.readInFile(Paths.oneChoiceQuestionPath, false);
            var list3 = TextQuestion.readInFile(Paths.textQuestionPath, false);

            List<IQuestionable> allQuestions = new List<IQuestionable>();
            foreach(var item in list1)
                allQuestions.Add(item);
            foreach (var item in list2)
                allQuestions.Add(item);
            foreach (var item in list3)
                allQuestions.Add(item);
            Shuffle(ref allQuestions);

            if (allQuestions.Count == 0)
            {
                MessageBox.Show("В экзамене нет ни одного вопроса!", "Ошибка");
                Application.Exit();
            }
                
            // Инициализация используемых в приложении конструкций
            this.current = allQuestions[0];
            for(int i = 1; i < allQuestions.Count; i++)
            {
                this.right.Push(allQuestions[i]);
            }

            // Отображение текущего вопроса
            display();
        }

        /* Запись ответа пользователя в current и переход на шаг назад */
        private void backButton_Click(object sender, EventArgs e)
        {
            if (this.left.Count != 0)
            {
                // Запись ответа пользователя в объект
                writeAnswer();

                // Переход к другому вопросу
                this.userAnswers.Controls.Clear();
                this.right.Push(this.current);
                this.current = this.left.Pop();
                this.counterQuestions--;

                //Отображение нового вопроса
                display();
            }
        }

        /* Запись ответа пользователя в current и переход на шаг вперёд */
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (this.right.Count != 0)
            {
                // Запись ответа пользователя в объект
                writeAnswer();

                // Переход к другому вопросу
                this.userAnswers.Controls.Clear();
                this.left.Push(this.current);
                this.current = this.right.Pop();
                this.counterQuestions++;

                //Отображение нового вопроса
                display();
            }
        }

        /* Запись ответа из формы в current */
        private void writeAnswer()
        {
            if (this.current is TextQuestion)
            {
                string userAnswerInTextBox = 
                    this.userAnswers.Controls.OfType<TextBox>().FirstOrDefault().Text;
                if (userAnswerInTextBox != null)
                {
                    TextQuestion textQuestion = (TextQuestion)this.current;
                    textQuestion.userAnswer = userAnswerInTextBox;
                    this.current = textQuestion;
                }
            }
            if (this.current is OneChoiceQuestion)
            {
                var checkedVariant = this.userAnswers.Controls.
                                        OfType<RadioButton>().
                                        FirstOrDefault(n => n.Checked);
                if (checkedVariant != null)
                {
                    string checkedVariantText = checkedVariant.Text;
                    OneChoiceQuestion oneChoiceQuestion = (OneChoiceQuestion)this.current;
                    oneChoiceQuestion.userAnswer = checkedVariantText;
                    this.current = oneChoiceQuestion;
                }
            }
            if (this.current is MultiplyChoiceQuestion)
            {
                var checkedVariantList = this.userAnswers.Controls.
                                        OfType<CheckBox>().
                                        Where(n => n.Checked);
                if(checkedVariantList != null)
                {
                    List<string> chVList = checkedVariantList.
                                        Select(x => x.Text).
                                        ToList();
                    MultiplyChoiceQuestion multiplyChoiceQuestion = (MultiplyChoiceQuestion)this.current;
                    multiplyChoiceQuestion.userAnswers = chVList;
                    this.current = multiplyChoiceQuestion;
                }
            }
        }

        /* Отображение current на экране */
        private void display()
        {
            counterQuestionsLabel.Text = counterQuestions.ToString();
            if (this.current is TextQuestion)
            {
                TextQuestion textQuestion = (TextQuestion)this.current;

                questionTextBox.Text = textQuestion.formulation;

                TextBox tb = new TextBox();
                tb.Location = new Point(gap, gap * 2);

                userAnswers.Controls.Add(tb);

                Button buttonText = new Button();
                buttonText.Text = "Очистить ответ";
                buttonText.Width = 100;
                buttonText.Location = new Point(gap, gap * 5);
                buttonText.Click += ButtonText_Click;

                userAnswers.Controls.Add(buttonText);

                if (textQuestion.userAnswer != null)
                {
                    tb.Text = textQuestion.userAnswer;
                }
            }
            if (this.current is OneChoiceQuestion)
            {
                OneChoiceQuestion oneChoiceQuestion = (OneChoiceQuestion)this.current;

                questionTextBox.Text = oneChoiceQuestion.formulation;

                int y = gap * 2;
                foreach(var variation in oneChoiceQuestion.variants)
                {
                    RadioButton rb = new RadioButton();
                    rb.Location = new Point(xStart, y);
                    rb.Width = 400;
                    rb.Text = variation.answer;

                    // Если совпало с ответом пользователя
                    if (variation.answer == oneChoiceQuestion.userAnswer)
                        rb.Checked = true;

                    userAnswers.Controls.Add(rb);
                    y += gap * 2;
                }

                Button buttonOne = new Button();
                buttonOne.Text = "Очистить ответ";
                buttonOne.Width = 100;
                buttonOne.Location = new Point(gap, y + 20);
                buttonOne.Click += ButtonOne_Click;

                userAnswers.Controls.Add(buttonOne);
            }
            if (this.current is MultiplyChoiceQuestion)
            {
                MultiplyChoiceQuestion multiplyChoiceQuestion = (MultiplyChoiceQuestion)this.current;

                questionTextBox.Text = multiplyChoiceQuestion.formulation;

                int y = gap * 2;
                foreach (var variation in multiplyChoiceQuestion.variants)
                {
                    CheckBox chb = new CheckBox();
                    chb.Location = new Point(xStart, y);
                    chb.Width = 400;
                    chb.Text = variation.answer;

                    // Если совпало с ответом пользователя
                    if (multiplyChoiceQuestion.userAnswers != null)
                    {
                        if (multiplyChoiceQuestion.userAnswers.Contains(variation.answer))
                            chb.Checked = true;
                    }

                    userAnswers.Controls.Add(chb);
                    y += gap * 2;
                }

                Button buttonMultiplicity = new Button();
                buttonMultiplicity.Text = "Очистить ответ";
                buttonMultiplicity.Width = 100;
                buttonMultiplicity.Location = new Point(gap, y + 20);
                buttonMultiplicity.Click += ButtonMultiplicity_Click;

                userAnswers.Controls.Add(buttonMultiplicity);
            }
        }

        private void ButtonText_Click(object sender, EventArgs eventArgs)
        {
            var checkedVariantList = this.userAnswers.Controls.
                                        OfType<TextBox>().
                                        FirstOrDefault();
            checkedVariantList.Text = null;
            display();
        }

        private void ButtonOne_Click(object sender, EventArgs eventArgs)
        {
            var checkedVariantList = this.userAnswers.Controls.
                                        OfType<RadioButton>().
                                        FirstOrDefault(n => n.Checked);
            checkedVariantList.Checked = false;
            display();
        }

        private void ButtonMultiplicity_Click(object sender, EventArgs eventArgs)
        {
            var checkedVariantList = this.userAnswers.Controls.
                                        OfType<CheckBox>().
                                        Where(n => n.Checked);
            foreach (var variant in checkedVariantList)
            {
                variant.Checked = false;
            }
            display();
        }

        /* Формирует строку с неотвеченными вопросами */
        public string guardNonAnswered()
        {
            string result = "";
            List<IQuestionable> all = toList();

            foreach(var question in all)
            {
                if(question is TextQuestion)
                {
                    TextQuestion textQuestion = (TextQuestion)question;
                    if (textQuestion.userAnswer == null ||
                        textQuestion.userAnswer == "")
                        result += (all.IndexOf(textQuestion) + 1) + ", ";
                }
                if (question is OneChoiceQuestion)
                {
                    OneChoiceQuestion oneChoiceQuestion = (OneChoiceQuestion)question;
                    if (oneChoiceQuestion.userAnswer == null ||
                        oneChoiceQuestion.userAnswer.Length == 0)
                        result += (all.IndexOf(oneChoiceQuestion) + 1) + ", ";
                }
                if (question is MultiplyChoiceQuestion)
                {
                    MultiplyChoiceQuestion multiplyChoiceQuestion = (MultiplyChoiceQuestion)question;
                    if (multiplyChoiceQuestion.userAnswers == null ||
                        multiplyChoiceQuestion.userAnswers.Count == 0)
                        result += (all.IndexOf(multiplyChoiceQuestion) + 1) + ", ";
                }
            }

            if (result == "") return result;
            return result.Substring(0, result.Length - 2);
        }

        /* Возвращает список всех вопросов из стеков и current */
        public List<IQuestionable> toList()
        {
            List<IQuestionable> list = new List<IQuestionable>();
            Stack<IQuestionable> copyLeft = CloneStack.Clone(this.left);
            Stack<IQuestionable> copyRight = CloneStack.Clone(this.right);

            while(copyRight.Count > 0)
            {
                list.Add(copyRight.Pop());
            }
            list.Insert(0, this.current);
            while(copyLeft.Count > 0)
            {
                list.Insert(0, copyLeft.Pop());
            }
            return list;
        }

        /* Перемешивает вопросы в случайном порядке */
        public static void Shuffle<T>(ref List<T> list)
        {
            Random rand = new Random();

            for (int i = list.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                T tmp = list[j];
                list[j] = list[i];
                list[i] = tmp;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan span = checkTime - DateTime.Now;
            int h = span.Hours;
            int m = span.Minutes;
            int s = span.Seconds;
            timeLabel.Text = String.Format("{0}:{1}:{2}", h, m, s);
            if (h == 0 && m == 0 && s == 0)
            {
                timer.Stop();
                this.Hide();
                writeAnswer();
                Form form = new ResultForm(toList());
                form.Show();
            }
        }

        /* Репорт пользователю и переход к результатам */
        private void endExamButton_Click(object sender, EventArgs e)
        {
            writeAnswer();
            string report = guardNonAnswered();
            if (report != "")
            {
                report = "Нет ответа на " + report + " вопросы.\n Вы уверены?";
                DialogResult result = MessageBox.Show(
                    report,
                    "Запрос подтверждения",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (result == DialogResult.Yes)
                    giveMeResult();
            }
            else
                giveMeResult();
        }

        /* Переход к форме результатов */
        private void giveMeResult()
        {
            timer.Stop();
            this.Hide();
            writeAnswer();
            Form form = new ResultForm(toList());
            form.Show();
        }

        private void Exam_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
