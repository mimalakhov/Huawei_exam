namespace exam
{
    partial class StartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.startExamButton = new System.Windows.Forms.Button();
            this.addingQuestionsButton = new System.Windows.Forms.Button();
            this.deleteQuestionButton = new System.Windows.Forms.Button();
            this.blockQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // startExamButton
            // 
            this.startExamButton.Location = new System.Drawing.Point(68, 60);
            this.startExamButton.Name = "startExamButton";
            this.startExamButton.Size = new System.Drawing.Size(192, 37);
            this.startExamButton.TabIndex = 1;
            this.startExamButton.Text = "Начать экзамен";
            this.startExamButton.UseVisualStyleBackColor = true;
            this.startExamButton.Click += new System.EventHandler(this.startExamButton_Click);
            // 
            // addingQuestionsButton
            // 
            this.addingQuestionsButton.Location = new System.Drawing.Point(68, 114);
            this.addingQuestionsButton.Name = "addingQuestionsButton";
            this.addingQuestionsButton.Size = new System.Drawing.Size(192, 37);
            this.addingQuestionsButton.TabIndex = 2;
            this.addingQuestionsButton.Text = "Режим добавления вопросов";
            this.addingQuestionsButton.UseVisualStyleBackColor = true;
            this.addingQuestionsButton.Click += new System.EventHandler(this.addingQuestionsButton_Click);
            // 
            // deleteQuestionButton
            // 
            this.deleteQuestionButton.Location = new System.Drawing.Point(68, 166);
            this.deleteQuestionButton.Name = "deleteQuestionButton";
            this.deleteQuestionButton.Size = new System.Drawing.Size(192, 37);
            this.deleteQuestionButton.TabIndex = 3;
            this.deleteQuestionButton.Text = "Режим удаления вопросов";
            this.deleteQuestionButton.UseVisualStyleBackColor = true;
            this.deleteQuestionButton.Click += new System.EventHandler(this.deleteQuestionButton_Click);
            // 
            // blockQuestionButton
            // 
            this.blockQuestionButton.Location = new System.Drawing.Point(68, 220);
            this.blockQuestionButton.Name = "blockQuestionButton";
            this.blockQuestionButton.Size = new System.Drawing.Size(192, 37);
            this.blockQuestionButton.TabIndex = 4;
            this.blockQuestionButton.Text = "Режим блокирования вопросов";
            this.blockQuestionButton.UseVisualStyleBackColor = true;
            this.blockQuestionButton.Click += new System.EventHandler(this.blockQuestionButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 314);
            this.Controls.Add(this.blockQuestionButton);
            this.Controls.Add(this.deleteQuestionButton);
            this.Controls.Add(this.addingQuestionsButton);
            this.Controls.Add(this.startExamButton);
            this.Controls.Add(this.label1);
            this.Name = "StartForm";
            this.Text = "Экзамен";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startExamButton;
        private System.Windows.Forms.Button addingQuestionsButton;
        private System.Windows.Forms.Button deleteQuestionButton;
        private System.Windows.Forms.Button blockQuestionButton;
    }
}

