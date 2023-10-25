namespace exam
{
    partial class addQuestionForm
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
            this.typeQuestionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.numberVariantsComboBox = new System.Windows.Forms.ComboBox();
            this.newFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeQuestionComboBox
            // 
            this.typeQuestionComboBox.FormattingEnabled = true;
            this.typeQuestionComboBox.Location = new System.Drawing.Point(12, 33);
            this.typeQuestionComboBox.Name = "typeQuestionComboBox";
            this.typeQuestionComboBox.Size = new System.Drawing.Size(224, 21);
            this.typeQuestionComboBox.TabIndex = 0;
            this.typeQuestionComboBox.SelectedIndexChanged += new System.EventHandler(this.typeQuestionComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите тип нового вопроса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите количество вариантов ответов:";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(258, 33);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(99, 48);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Сгенерировать форму";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Location = new System.Drawing.Point(12, 126);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(345, 359);
            this.mainGroupBox.TabIndex = 5;
            this.mainGroupBox.TabStop = false;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(12, 491);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(114, 24);
            this.addItemButton.TabIndex = 6;
            this.addItemButton.Text = "Добавить";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(132, 491);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(114, 24);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // numberVariantsComboBox
            // 
            this.numberVariantsComboBox.FormattingEnabled = true;
            this.numberVariantsComboBox.Location = new System.Drawing.Point(12, 91);
            this.numberVariantsComboBox.Name = "numberVariantsComboBox";
            this.numberVariantsComboBox.Size = new System.Drawing.Size(224, 21);
            this.numberVariantsComboBox.TabIndex = 8;
            // 
            // newFormButton
            // 
            this.newFormButton.Location = new System.Drawing.Point(258, 87);
            this.newFormButton.Name = "newFormButton";
            this.newFormButton.Size = new System.Drawing.Size(99, 25);
            this.newFormButton.TabIndex = 9;
            this.newFormButton.Text = "Новая форма";
            this.newFormButton.UseVisualStyleBackColor = true;
            this.newFormButton.Click += new System.EventHandler(this.newFormButton_Click);
            // 
            // addQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 525);
            this.Controls.Add(this.newFormButton);
            this.Controls.Add(this.numberVariantsComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.mainGroupBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeQuestionComboBox);
            this.Name = "addQuestionForm";
            this.Text = "Добавить вопрос";
            this.Load += new System.EventHandler(this.addQuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeQuestionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox numberVariantsComboBox;
        private System.Windows.Forms.Button newFormButton;
    }
}