namespace exam.Forms
{
    partial class DeleteQuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deleteTextComboBox = new System.Windows.Forms.ComboBox();
            this.deleteOneComboBox = new System.Windows.Forms.ComboBox();
            this.deleteMultiplyComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteTextButton = new System.Windows.Forms.Button();
            this.deleteOneButton = new System.Windows.Forms.Button();
            this.deleteMultiplyButton = new System.Windows.Forms.Button();
            this.closeDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteTextComboBox
            // 
            this.deleteTextComboBox.FormattingEnabled = true;
            this.deleteTextComboBox.Location = new System.Drawing.Point(12, 38);
            this.deleteTextComboBox.Name = "deleteTextComboBox";
            this.deleteTextComboBox.Size = new System.Drawing.Size(207, 21);
            this.deleteTextComboBox.TabIndex = 0;
            // 
            // deleteOneComboBox
            // 
            this.deleteOneComboBox.FormattingEnabled = true;
            this.deleteOneComboBox.Location = new System.Drawing.Point(225, 38);
            this.deleteOneComboBox.Name = "deleteOneComboBox";
            this.deleteOneComboBox.Size = new System.Drawing.Size(207, 21);
            this.deleteOneComboBox.TabIndex = 1;
            // 
            // deleteMultiplyComboBox
            // 
            this.deleteMultiplyComboBox.FormattingEnabled = true;
            this.deleteMultiplyComboBox.Location = new System.Drawing.Point(438, 38);
            this.deleteMultiplyComboBox.Name = "deleteMultiplyComboBox";
            this.deleteMultiplyComboBox.Size = new System.Drawing.Size(207, 21);
            this.deleteMultiplyComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Удалить текстовый вопрос";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Удалить вопрос с одним\r\nверным ответом";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Удалить вопрос с несколькими\r\nверными ответами";
            // 
            // deleteTextButton
            // 
            this.deleteTextButton.Location = new System.Drawing.Point(15, 70);
            this.deleteTextButton.Name = "deleteTextButton";
            this.deleteTextButton.Size = new System.Drawing.Size(111, 21);
            this.deleteTextButton.TabIndex = 6;
            this.deleteTextButton.Text = "Удалить";
            this.deleteTextButton.UseVisualStyleBackColor = true;
            this.deleteTextButton.Click += new System.EventHandler(this.deleteTextButton_Click);
            // 
            // deleteOneButton
            // 
            this.deleteOneButton.Location = new System.Drawing.Point(225, 70);
            this.deleteOneButton.Name = "deleteOneButton";
            this.deleteOneButton.Size = new System.Drawing.Size(111, 21);
            this.deleteOneButton.TabIndex = 7;
            this.deleteOneButton.Text = "Удалить";
            this.deleteOneButton.UseVisualStyleBackColor = true;
            this.deleteOneButton.Click += new System.EventHandler(this.deleteOneButton_Click);
            // 
            // deleteMultiplyButton
            // 
            this.deleteMultiplyButton.Location = new System.Drawing.Point(438, 70);
            this.deleteMultiplyButton.Name = "deleteMultiplyButton";
            this.deleteMultiplyButton.Size = new System.Drawing.Size(111, 21);
            this.deleteMultiplyButton.TabIndex = 8;
            this.deleteMultiplyButton.Text = "Удалить";
            this.deleteMultiplyButton.UseVisualStyleBackColor = true;
            this.deleteMultiplyButton.Click += new System.EventHandler(this.deleteMultiplyButton_Click);
            // 
            // closeDeleteButton
            // 
            this.closeDeleteButton.Location = new System.Drawing.Point(533, 100);
            this.closeDeleteButton.Name = "closeDeleteButton";
            this.closeDeleteButton.Size = new System.Drawing.Size(112, 21);
            this.closeDeleteButton.TabIndex = 9;
            this.closeDeleteButton.Text = "Закрыть";
            this.closeDeleteButton.UseVisualStyleBackColor = true;
            this.closeDeleteButton.Click += new System.EventHandler(this.closeDeleteButton_Click);
            // 
            // DeleteQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 133);
            this.Controls.Add(this.closeDeleteButton);
            this.Controls.Add(this.deleteMultiplyButton);
            this.Controls.Add(this.deleteOneButton);
            this.Controls.Add(this.deleteTextButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteMultiplyComboBox);
            this.Controls.Add(this.deleteOneComboBox);
            this.Controls.Add(this.deleteTextComboBox);
            this.Name = "DeleteQuestionForm";
            this.Text = "Удалить вопрос";
            this.Load += new System.EventHandler(this.DeleteQuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox deleteTextComboBox;
        private System.Windows.Forms.ComboBox deleteOneComboBox;
        private System.Windows.Forms.ComboBox deleteMultiplyComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteTextButton;
        private System.Windows.Forms.Button deleteOneButton;
        private System.Windows.Forms.Button deleteMultiplyButton;
        private System.Windows.Forms.Button closeDeleteButton;
    }
}