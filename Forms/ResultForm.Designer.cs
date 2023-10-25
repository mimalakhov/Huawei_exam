namespace exam
{
    partial class ResultForm
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
            this.passOrFailLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfPointsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.rapportTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // passOrFailLabel
            // 
            this.passOrFailLabel.AutoSize = true;
            this.passOrFailLabel.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passOrFailLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passOrFailLabel.Location = new System.Drawing.Point(25, 9);
            this.passOrFailLabel.Name = "passOrFailLabel";
            this.passOrFailLabel.Size = new System.Drawing.Size(76, 27);
            this.passOrFailLabel.TabIndex = 0;
            this.passOrFailLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество баллов:";
            // 
            // numberOfPointsLabel
            // 
            this.numberOfPointsLabel.AutoSize = true;
            this.numberOfPointsLabel.Location = new System.Drawing.Point(126, 56);
            this.numberOfPointsLabel.Name = "numberOfPointsLabel";
            this.numberOfPointsLabel.Size = new System.Drawing.Size(35, 13);
            this.numberOfPointsLabel.TabIndex = 2;
            this.numberOfPointsLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Процент прохождения:";
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Location = new System.Drawing.Point(315, 56);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(35, 13);
            this.percentageLabel.TabIndex = 4;
            this.percentageLabel.Text = "label3";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 311);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 25);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Закрыть";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(129, 311);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 25);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Сохранить в txt";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // rapportTextBox
            // 
            this.rapportTextBox.Location = new System.Drawing.Point(12, 80);
            this.rapportTextBox.Name = "rapportTextBox";
            this.rapportTextBox.Size = new System.Drawing.Size(543, 225);
            this.rapportTextBox.TabIndex = 8;
            this.rapportTextBox.Text = "";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(561, 80);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(211, 225);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(243, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 11);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите Ваше имя для сохранения:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(434, 314);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 11;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 348);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.rapportTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberOfPointsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passOrFailLabel);
            this.Name = "ResultForm";
            this.Text = "Результаты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultForm_FormClosing);
            this.Load += new System.EventHandler(this.ResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passOrFailLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberOfPointsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RichTextBox rapportTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}