using exam.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void startExamButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exam exam = new Exam();
            exam.Show();
        }

        private void addingQuestionsButton_Click(object sender, EventArgs e)
        {
            PasswordForm form = new PasswordForm(From.Adding);
            form.ShowDialog();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            PasswordForm form = new PasswordForm(From.Deleting);
            form.ShowDialog();
        }

        private void blockQuestionButton_Click(object sender, EventArgs e)
        {
            PasswordForm form = new PasswordForm(From.Blocking);
            form.ShowDialog();
        }
    }
}
