namespace exam.Forms
{
    partial class BlockQuestionForm
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
            this.blockTextComboBox = new System.Windows.Forms.ComboBox();
            this.unblockTextComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.blockOneComboBox = new System.Windows.Forms.ComboBox();
            this.blockMulComboBox = new System.Windows.Forms.ComboBox();
            this.unblockOneComboBox = new System.Windows.Forms.ComboBox();
            this.unblockMulComboBox = new System.Windows.Forms.ComboBox();
            this.blockTextButton = new System.Windows.Forms.Button();
            this.blockOneButton = new System.Windows.Forms.Button();
            this.blockMulButton = new System.Windows.Forms.Button();
            this.unblockTextButton = new System.Windows.Forms.Button();
            this.unblockOneButton = new System.Windows.Forms.Button();
            this.unblockMulButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // blockTextComboBox
            // 
            this.blockTextComboBox.FormattingEnabled = true;
            this.blockTextComboBox.Location = new System.Drawing.Point(12, 33);
            this.blockTextComboBox.Name = "blockTextComboBox";
            this.blockTextComboBox.Size = new System.Drawing.Size(209, 21);
            this.blockTextComboBox.TabIndex = 0;
            // 
            // unblockTextComboBox
            // 
            this.unblockTextComboBox.FormattingEnabled = true;
            this.unblockTextComboBox.Location = new System.Drawing.Point(354, 33);
            this.unblockTextComboBox.Name = "unblockTextComboBox";
            this.unblockTextComboBox.Size = new System.Drawing.Size(209, 21);
            this.unblockTextComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Блокировать вопрос";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Деблокировать вопрос";
            // 
            // blockOneComboBox
            // 
            this.blockOneComboBox.FormattingEnabled = true;
            this.blockOneComboBox.Location = new System.Drawing.Point(12, 66);
            this.blockOneComboBox.Name = "blockOneComboBox";
            this.blockOneComboBox.Size = new System.Drawing.Size(209, 21);
            this.blockOneComboBox.TabIndex = 6;
            // 
            // blockMulComboBox
            // 
            this.blockMulComboBox.FormattingEnabled = true;
            this.blockMulComboBox.Location = new System.Drawing.Point(12, 102);
            this.blockMulComboBox.Name = "blockMulComboBox";
            this.blockMulComboBox.Size = new System.Drawing.Size(209, 21);
            this.blockMulComboBox.TabIndex = 7;
            // 
            // unblockOneComboBox
            // 
            this.unblockOneComboBox.FormattingEnabled = true;
            this.unblockOneComboBox.Location = new System.Drawing.Point(354, 66);
            this.unblockOneComboBox.Name = "unblockOneComboBox";
            this.unblockOneComboBox.Size = new System.Drawing.Size(209, 21);
            this.unblockOneComboBox.TabIndex = 8;
            // 
            // unblockMulComboBox
            // 
            this.unblockMulComboBox.FormattingEnabled = true;
            this.unblockMulComboBox.Location = new System.Drawing.Point(354, 102);
            this.unblockMulComboBox.Name = "unblockMulComboBox";
            this.unblockMulComboBox.Size = new System.Drawing.Size(209, 21);
            this.unblockMulComboBox.TabIndex = 9;
            // 
            // blockTextButton
            // 
            this.blockTextButton.Location = new System.Drawing.Point(229, 33);
            this.blockTextButton.Name = "blockTextButton";
            this.blockTextButton.Size = new System.Drawing.Size(82, 21);
            this.blockTextButton.TabIndex = 10;
            this.blockTextButton.Text = "Блокировать";
            this.blockTextButton.UseVisualStyleBackColor = true;
            this.blockTextButton.Click += new System.EventHandler(this.blockTextButton_Click);
            // 
            // blockOneButton
            // 
            this.blockOneButton.Location = new System.Drawing.Point(229, 66);
            this.blockOneButton.Name = "blockOneButton";
            this.blockOneButton.Size = new System.Drawing.Size(82, 21);
            this.blockOneButton.TabIndex = 11;
            this.blockOneButton.Text = "Блокировать";
            this.blockOneButton.UseVisualStyleBackColor = true;
            this.blockOneButton.Click += new System.EventHandler(this.blockOneButton_Click);
            // 
            // blockMulButton
            // 
            this.blockMulButton.Location = new System.Drawing.Point(229, 101);
            this.blockMulButton.Name = "blockMulButton";
            this.blockMulButton.Size = new System.Drawing.Size(82, 21);
            this.blockMulButton.TabIndex = 12;
            this.blockMulButton.Text = "Блокировать";
            this.blockMulButton.UseVisualStyleBackColor = true;
            this.blockMulButton.Click += new System.EventHandler(this.blockMulButton_Click);
            // 
            // unblockTextButton
            // 
            this.unblockTextButton.Location = new System.Drawing.Point(573, 32);
            this.unblockTextButton.Name = "unblockTextButton";
            this.unblockTextButton.Size = new System.Drawing.Size(106, 21);
            this.unblockTextButton.TabIndex = 13;
            this.unblockTextButton.Text = "Деблокировать";
            this.unblockTextButton.UseVisualStyleBackColor = true;
            this.unblockTextButton.Click += new System.EventHandler(this.unblockTextButton_Click);
            // 
            // unblockOneButton
            // 
            this.unblockOneButton.Location = new System.Drawing.Point(573, 66);
            this.unblockOneButton.Name = "unblockOneButton";
            this.unblockOneButton.Size = new System.Drawing.Size(106, 21);
            this.unblockOneButton.TabIndex = 14;
            this.unblockOneButton.Text = "Деблокировать";
            this.unblockOneButton.UseVisualStyleBackColor = true;
            this.unblockOneButton.Click += new System.EventHandler(this.unblockOneButton_Click);
            // 
            // unblockMulButton
            // 
            this.unblockMulButton.Location = new System.Drawing.Point(573, 101);
            this.unblockMulButton.Name = "unblockMulButton";
            this.unblockMulButton.Size = new System.Drawing.Size(106, 21);
            this.unblockMulButton.TabIndex = 15;
            this.unblockMulButton.Text = "Деблокировать";
            this.unblockMulButton.UseVisualStyleBackColor = true;
            this.unblockMulButton.Click += new System.EventHandler(this.unblockMulButton_Click);
            // 
            // BlockQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 143);
            this.Controls.Add(this.unblockMulButton);
            this.Controls.Add(this.unblockOneButton);
            this.Controls.Add(this.unblockTextButton);
            this.Controls.Add(this.blockMulButton);
            this.Controls.Add(this.blockOneButton);
            this.Controls.Add(this.blockTextButton);
            this.Controls.Add(this.unblockMulComboBox);
            this.Controls.Add(this.unblockOneComboBox);
            this.Controls.Add(this.blockMulComboBox);
            this.Controls.Add(this.blockOneComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unblockTextComboBox);
            this.Controls.Add(this.blockTextComboBox);
            this.Name = "BlockQuestionForm";
            this.Text = "Блокировать вопрос";
            this.Load += new System.EventHandler(this.BlockQuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox blockTextComboBox;
        private System.Windows.Forms.ComboBox unblockTextComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox blockOneComboBox;
        private System.Windows.Forms.ComboBox blockMulComboBox;
        private System.Windows.Forms.ComboBox unblockOneComboBox;
        private System.Windows.Forms.ComboBox unblockMulComboBox;
        private System.Windows.Forms.Button blockTextButton;
        private System.Windows.Forms.Button blockOneButton;
        private System.Windows.Forms.Button blockMulButton;
        private System.Windows.Forms.Button unblockTextButton;
        private System.Windows.Forms.Button unblockOneButton;
        private System.Windows.Forms.Button unblockMulButton;
    }
}