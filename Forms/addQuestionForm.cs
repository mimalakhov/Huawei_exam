using exam.Classes;
using exam.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace exam
{
    public partial class addQuestionForm : Form
    {
        const int gap = 10;

        Type type;
        int numberVariant;

        public addQuestionForm()
        {
            InitializeComponent();
        }

        private void addQuestionForm_Load(object sender, EventArgs e)
        {
            typeQuestionComboBox.Items.Add("Вопрос с текстовым ответом");
            typeQuestionComboBox.Items.Add("Вопрос с одним верным ответом");
            typeQuestionComboBox.Items.Add("Вопрос со многими верными ответами");
            typeQuestionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            numberVariantsComboBox.Items.Add("2");
            numberVariantsComboBox.Items.Add("3");
            numberVariantsComboBox.Items.Add("4");
            numberVariantsComboBox.Items.Add("5");
            numberVariantsComboBox.Items.Add("6");
            numberVariantsComboBox.Items.Add("7");
            numberVariantsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            numberVariantsComboBox.Enabled = false;
        }

        private void typeQuestionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedState = typeQuestionComboBox.SelectedIndex;
            if (selectedState == 1 || selectedState == 2)
                numberVariantsComboBox.Enabled = true;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            cleanGroupBox();
            int selectedStateType = typeQuestionComboBox.SelectedIndex;
            int selectedStateNumber = Convert.ToInt32(numberVariantsComboBox.SelectedItem);

            // Исключительные ситуации
            if (selectedStateType == -1)
            {
                MessageBox.Show("Не введён тип вопроса!", "Ошибка");
                return;
            }
            if ((selectedStateType == 1 || selectedStateType == 2) && 
                selectedStateNumber == 0)
            {
                MessageBox.Show("Не введено количество ответов!", "Ошибка");
                return;
            }

            // Определяем главные параметры 
            init(selectedStateType, selectedStateNumber);

            // Создаём форму для ввода вопроса
            generateForm();
        }

        /* Определяем тип вопроса аи количество вариантов ответа*/
        private void init(int i1, int i2)
        {
            if (i1 == 0) this.type = Type.Text;
            if (i1 == 1) this.type = Type.OneChoice;
            if (i1 == 2) this.type = Type.MultiplyChoice;

            this.numberVariant = i2;
        }

        /* Генерирует нужные элементы для ввода вопроса*/
        private void generateForm()
        {
            addFormulation();
            if (this.type == Type.Text)
            {
                TextBox textBox = new TextBox();
                textBox.Location = new Point(gap, gap * 10);
                textBox.Multiline = true;
                textBox.Width = 100;

                mainGroupBox.Controls.Add(textBox);
            }
            if (this.type == Type.OneChoice)
            {
                for(int i = 0; i < this.numberVariant; i++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Location = new Point(gap, gap * (10 + i * 3));
                    textBox.Multiline = true;
                    textBox.Width = 100;

                    RadioButton rb = new RadioButton();
                    rb.Text = "Правильный";
                    rb.Location = new Point(gap + 120, gap * (10 + i * 3));

                    mainGroupBox.Controls.Add(textBox);
                    mainGroupBox.Controls.Add(rb);
                }
            }
            if (this.type == Type.MultiplyChoice)
            {
                for (int i = 0; i < this.numberVariant; i++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Location = new Point(gap, gap * (10 + i * 3));
                    textBox.Multiline = true;
                    textBox.Width = 100;

                    CheckBox chb = new CheckBox();
                    chb.Text = "Правильный";
                    chb.Location = new Point(gap + 120, gap * (10 + i * 3));

                    mainGroupBox.Controls.Add(textBox);
                    mainGroupBox.Controls.Add(chb);
                }
            }
        }

        /* Генерирует форму для добавления формулировки вопроса */
        private void addFormulation()
        {
            Label label1 = new Label();
            label1.Location = new Point(gap, gap);
            label1.Width = 200;
            label1.Text = "Введите формулировку:";

            TextBox textBox = new TextBox();
            textBox.Location = new Point(gap, gap * 4);
            textBox.Multiline = true;
            textBox.Width = 300;

            Label label2 = new Label();
            label2.Location = new Point(gap, gap * 7);
            label2.Width = 200;
            label2.Text = "Введите ответ:";

            mainGroupBox.Controls.Add(label1);
            mainGroupBox.Controls.Add(textBox);
            mainGroupBox.Controls.Add(label2);
        }

        /* Проверка того, что пользователь нигде не оставил поле для ввода
         пустым и что он обязательно выбрал правильные отверты*/
        private bool guard()
        {
            bool result = guardFormulation();
            if (this.type == Type.Text) 
            {
                var list =
                    this.mainGroupBox.Controls.OfType<TextBox>().ToList();
                if (list[1].Text == null ||
                    list[1].Text.Length == 0) result = result && false;
            }
            if (this.type == Type.OneChoice)
            {
                result = result && checkTextBoxes();

                bool check = false;
                var listRadioButton = 
                    this.mainGroupBox.Controls.OfType<RadioButton>();
                foreach(RadioButton radioButton in listRadioButton)
                {
                    check = check || radioButton.Checked;
                }

                result = result && check;
            }
            if(this.type == Type.MultiplyChoice)
            {
                result = result && checkTextBoxes();

                bool check = false;
                var listCheckBox =
                    this.mainGroupBox.Controls.OfType<CheckBox>();
                foreach (CheckBox checkBox in listCheckBox)
                {
                    check = check || checkBox.Checked;
                }

                result = result && check;
            }

            return result;
        }

        /* Проверка того, что пользователь ввёл формулировку вопроса */
        private bool guardFormulation()
        {
            string formulationTextBox =
                this.mainGroupBox.Controls.OfType<TextBox>().First().Text;
            if (formulationTextBox == null || 
                formulationTextBox.Length == 0)
                return false;
            return true;
        }

        /* Проверка всех сгенерированных textbox */
        private bool checkTextBoxes()
        {
            bool result = true;
            var list =
                this.mainGroupBox.Controls.OfType<TextBox>().ToList();
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].Text == null ||
                    list[i].Text.Length == 0) result = false;
            }
            return result;
        }

        /* Очистка groupbox для ввода нового вопроса */
        private void cleanGroupBox()
        {
            mainGroupBox.Controls.Clear();
        }

        /* Добавление нового вопроса в хранилище */
        private void addItemButton_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли неправильный ввод
            if (!guard())
            {
                MessageBox.Show("Неверный ввод!", "Ошибка");
                return;
            }

            string formulation = getFormulation();

            if (this.type == Type.Text)
            {
                string rigthAnswer =
                    mainGroupBox.Controls.OfType<TextBox>().ToList()[1].Text;
                TextQuestion q = new TextQuestion(
                    formulation,
                    rigthAnswer
                    );
                q.writeInFile(Paths.textQuestionPath);
            }
            if (this.type == Type.OneChoice)
            {
                var variations = mainGroupBox.Controls.OfType<TextBox>().ToList();
                var checkers = mainGroupBox.Controls.OfType<RadioButton>().ToList();

                List<Variant> variantsToSave = new List<Variant>();

                for (int i = 1; i < variations.Count; i++)
                {
                    string answer = variations[i].Text;
                    bool correct = checkers[i - 1].Checked;

                    variantsToSave.Add(new Variant(
                        answer,
                        correct
                        ));
                }

                OneChoiceQuestion q = new OneChoiceQuestion(
                    formulation,
                    variantsToSave,
                    null
                    );
                q.writeInFile(Paths.oneChoiceQuestionPath);
            }
            if (this.type == Type.MultiplyChoice)
            {
                var variations = mainGroupBox.Controls.OfType<TextBox>().ToList();
                var checkers = mainGroupBox.Controls.OfType<CheckBox>().ToList();

                List<Variant> variants = new List<Variant>();

                for(int i = 1; i < variations.Count; i++)
                {
                    string variant = variations[i].Text;
                    bool isRigth = checkers[i - 1].Checked;
                    variants.Add(new Variant(
                        variant,
                        isRigth)
                    );
                }

                MultiplyChoiceQuestion q = new MultiplyChoiceQuestion(
                    formulation,
                    variants,
                    null);
                q.writeInFile(Paths.multiplyChoiceQuestionPath);
            }

            cleanGroupBox();
        }

        /* Возвращает формулировку вопроса */
        private string getFormulation()
        {
            return mainGroupBox.Controls.OfType<TextBox>().First().Text;
        }

        /* Очищение GroupBox перед созданием новой формы */
        private void newFormButton_Click(object sender, EventArgs e)
        {
            cleanGroupBox();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
