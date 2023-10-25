using exam.Forms;
using System;
using System.Windows.Forms;

namespace exam
{
    public partial class PasswordForm : Form
    {
        From from;
        public PasswordForm(From from)
        {
            InitializeComponent();
            this.from = from;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != "huawei201")
                MessageBox.Show("Неверный пароль!", "Ошибка");
            else
            {
                if (this.from == From.Deleting)
                {
                    DeleteQuestionForm form1 = new DeleteQuestionForm();
                    form1.ShowDialog();
                }
                if (this.from == From.Adding)
                {
                    addQuestionForm form1 = new addQuestionForm();
                    form1.ShowDialog();
                }
                if (this.from == From.Blocking)
                {
                    BlockQuestionForm form1 = new BlockQuestionForm();
                    form1.ShowDialog();
                }
            }
            this.Close();
        }

    }
}
