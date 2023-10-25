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
    public partial class BlockQuestionForm : Form
    {
        const string blocked = "(Заблокировано)";

        string mulPath;
        string onePath;
        string textPath;

        public BlockQuestionForm()
        {
            InitializeComponent();
        }

        private void BlockQuestionForm_Load(object sender, EventArgs e)
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

            blockTextComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            blockOneComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            blockMulComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            unblockTextComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unblockOneComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unblockMulComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            reload();
        }

        private void reload()
        {
            // Слияние всех вопросов в одну коллекцию
            var listMul = MultiplyChoiceQuestion.readInFile(this.mulPath, true);
            var listOne = OneChoiceQuestion.readInFile(this.onePath, true);
            var listText = TextQuestion.readInFile(this.textPath, true);

            var listNonBlockedText =
                listText.Where(x => !x.formulation.Contains(blocked))
                        .Select(x => x.formulation)
                        .ToList();
            var listBlockedText =
                listText.Where(x => x.formulation.Contains(blocked))
                        .Select(x => x.formulation)
                        .ToList();

            var listNonBlockedOne =
                listOne.Where(x => !x.formulation.Contains(blocked))
                        .Select(x => x.formulation)
                        .ToList();
            var listBlockedOne =
                listOne.Where(x => x.formulation.Contains(blocked))
                        .Select(x => x.formulation)
                        .ToList();

            var listNonBlockedMul =
                listMul.Where(x => !x.formulation.Contains(blocked))
                        .Select(x => x.formulation)
                        .ToList();
            var listBlockedMul=
                listMul.Where(x => x.formulation.Contains(blocked))
                        .Select(x => x.formulation)
                        .ToList();

            blockTextComboBox.DataSource = listNonBlockedText;
            unblockTextComboBox.DataSource = listBlockedText;

            blockOneComboBox.DataSource = listNonBlockedOne;
            unblockOneComboBox.DataSource = listBlockedOne;

            blockMulComboBox.DataSource = listNonBlockedMul;
            unblockMulComboBox.DataSource = listBlockedMul;
        }

        private void blockQuestion(string path, int index)
        {
            string[] lines = File.ReadAllLines(path);

            string result = "";
            int counterNonBlocked = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (counterNonBlocked != index)
                    result += lines[i] + "\n";
                else
                    result += "#" + lines[i] + "\n";

                if (lines[i].Substring(0, 1) != "#")
                    counterNonBlocked++;
            }

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.Write(result);
            }
        }

        private void unblockQuestion(string path, int index)
        {
            string[] lines = File.ReadAllLines(path);

            string result = "";
            int counterBlocked = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (counterBlocked != index)
                    result += lines[i] + "\n";
                else
                    result += lines[i].Replace("#", "") + "\n";

                if (lines[i].Substring(0, 1) == "#")
                    counterBlocked++;
            }

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.Write(result);
            }
        }

        private void blockTextButton_Click(object sender, EventArgs e)
        {
            if (blockTextComboBox.SelectedIndex != -1)
            {
                int index = blockTextComboBox.SelectedIndex;
                blockQuestion(textPath, index);
                reload();
            }
        }
        
        private void blockOneButton_Click(object sender, EventArgs e)
        {
            if (blockOneComboBox.SelectedIndex != -1)
            {
                int index = blockOneComboBox.SelectedIndex;
                blockQuestion(onePath, index);
                reload();
            }
        }

        private void blockMulButton_Click(object sender, EventArgs e)
        {
            if (blockMulComboBox.SelectedIndex != -1)
            {
                int index = blockMulComboBox.SelectedIndex;
                blockQuestion(mulPath, index);
                reload();
            }
        }

        private void unblockTextButton_Click(object sender, EventArgs e)
        {
            if (unblockTextComboBox.SelectedIndex != -1)
            {
                int index = unblockTextComboBox.SelectedIndex;
                unblockQuestion(textPath, index);
                reload();
            }
        }

        private void unblockOneButton_Click(object sender, EventArgs e)
        {
            if (unblockOneComboBox.SelectedIndex != -1)
            {
                int index = unblockOneComboBox.SelectedIndex;
                unblockQuestion(onePath, index);
                reload();
            }
        }

        private void unblockMulButton_Click(object sender, EventArgs e)
        {
            if (unblockMulComboBox.SelectedIndex != -1)
            {
                int index = unblockMulComboBox.SelectedIndex;
                unblockQuestion(mulPath, index);
                reload();
            }
        }
    }
}
