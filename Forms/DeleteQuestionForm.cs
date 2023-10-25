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

namespace exam.Forms
{
    public partial class DeleteQuestionForm : Form
    {
        string mulPath;
        string onePath;
        string textPath;

        public DeleteQuestionForm()
        {
            InitializeComponent();
        }

        private void DeleteQuestionForm_Load(object sender, EventArgs e)
        {
            // Выгрузка данных из файлов
            string appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            string multiplyChoiceQuestionPath = @"Questions\multiplyChoiceQuestion.txt";
            multiplyChoiceQuestionPath = Path.Combine(appDir, multiplyChoiceQuestionPath);
            string oneChoiceQuestionPath = @"Questions\oneChoiceQuestion.txt";
            oneChoiceQuestionPath = Path.Combine(appDir, oneChoiceQuestionPath);
            string textQuestionPath = @"Questions\textQuestion.txt";
            textQuestionPath = Path.Combine(appDir, textQuestionPath);

            this.mulPath = multiplyChoiceQuestionPath;
            this.onePath = oneChoiceQuestionPath;
            this.textPath = textQuestionPath;

            deleteTextComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deleteOneComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deleteMultiplyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            reload();
        }

        private void reload()
        {
            var listText =
                TextQuestion.readInFile(this.textPath, true).Select(x => x.formulation).ToList();
            var listOne =
                OneChoiceQuestion.readInFile(this.onePath, true).Select(x => x.formulation).ToList();
            var listMultiply =
                MultiplyChoiceQuestion.readInFile(this.mulPath, true).Select(x => x.formulation).ToList();

            // Заносим в ComboBox
            deleteTextComboBox.DataSource = listText;
            deleteOneComboBox.DataSource = listOne;
            deleteMultiplyComboBox.DataSource = listMultiply;
        }

        private DialogResult areYouSure()
        {
            string report = "Вы уверены?";
            DialogResult result = MessageBox.Show(
                report,
                "Запрос подтверждения",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            return result;
        }

        private void deleteQuestion(string path, int index)
        {
            string[] lines = File.ReadAllLines(path);

            string result = "";
            for(int i = 0; i < lines.Length; i++)
            {
                if (i != index)
                {
                    result += lines[i] + "\n";
                }
            }

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.Write(result);
            }
        }

        private void deleteTextButton_Click(object sender, EventArgs e)
        {
            DialogResult result = areYouSure();
            if (result == DialogResult.Yes)
            {
                int indexToDelete = deleteTextComboBox.SelectedIndex;

                deleteQuestion(this.textPath, indexToDelete);
            }

            reload();
        }

        private void deleteOneButton_Click(object sender, EventArgs e)
        {
            DialogResult result = areYouSure();
            if (result == DialogResult.Yes)
            {
                int indexToDelete = deleteOneComboBox.SelectedIndex;

                deleteQuestion(this.onePath, indexToDelete);
            }

            reload();
        }

        private void deleteMultiplyButton_Click(object sender, EventArgs e)
        {
            DialogResult result = areYouSure();
            if (result == DialogResult.Yes)
            {
                int indexToDelete = deleteMultiplyComboBox.SelectedIndex;

                deleteQuestion(this.mulPath, indexToDelete);
            }

            reload();
        }

        private void closeDeleteButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
