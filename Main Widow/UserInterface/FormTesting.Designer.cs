namespace UserInterface
{
    partial class FormTesting
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StartTest = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.Answer = new System.Windows.Forms.Button();
            this.DNK = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.End = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(150, 142);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(126, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тест";
            // 
            // StartTest
            // 
            this.StartTest.Location = new System.Drawing.Point(12, 30);
            this.StartTest.Name = "StartTest";
            this.StartTest.Size = new System.Drawing.Size(79, 31);
            this.StartTest.TabIndex = 4;
            this.StartTest.Text = "Начать Тест";
            this.StartTest.UseVisualStyleBackColor = true;
            this.StartTest.Click += new System.EventHandler(this.StartTest_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 67);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(79, 31);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Отмена";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(122, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.Text = "Ответ 2";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(122, 68);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Ответ 4";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(18, 30);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ответ 1";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(18, 68);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(64, 17);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.Text = "Ответ 3";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(377, 287);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(79, 31);
            this.Answer.TabIndex = 10;
            this.Answer.Text = "Ответ";
            this.Answer.UseVisualStyleBackColor = true;
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // DNK
            // 
            this.DNK.Location = new System.Drawing.Point(377, 324);
            this.DNK.Name = "DNK";
            this.DNK.Size = new System.Drawing.Size(79, 31);
            this.DNK.TabIndex = 11;
            this.DNK.Text = "Не знаю";
            this.DNK.UseVisualStyleBackColor = true;
            this.DNK.Click += new System.EventHandler(this.DNK_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButton3);
            this.groupBox.Controls.Add(this.radioButton1);
            this.groupBox.Controls.Add(this.radioButton2);
            this.groupBox.Controls.Add(this.radioButton4);
            this.groupBox.Location = new System.Drawing.Point(312, 163);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 94);
            this.groupBox.TabIndex = 12;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Ответы";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(307, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(215, 143);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(53, 287);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(142, 49);
            this.End.TabIndex = 16;
            this.End.Text = "Закончить Тест";
            this.End.UseVisualStyleBackColor = true;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // FormTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 366);
            this.Controls.Add(this.End);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.DNK);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.StartTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Name = "FormTesting";
            this.Text = "Тестирование";
            this.Load += new System.EventHandler(this.FormTesting_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartTest;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button Answer;
        private System.Windows.Forms.Button DNK;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button End;
    }
}