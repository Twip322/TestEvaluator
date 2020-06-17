namespace UserInterface
{
    partial class QuestAdd
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxANS1 = new System.Windows.Forms.TextBox();
            this.textBoxANS2 = new System.Windows.Forms.TextBox();
            this.textBoxANS3 = new System.Windows.Forms.TextBox();
            this.textBoxANS4 = new System.Windows.Forms.TextBox();
            this.textBoxRIGHT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(210, 160);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(113, 160);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(91, 23);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(152, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxANS1
            // 
            this.textBoxANS1.Location = new System.Drawing.Point(69, 38);
            this.textBoxANS1.Name = "textBoxANS1";
            this.textBoxANS1.Size = new System.Drawing.Size(100, 20);
            this.textBoxANS1.TabIndex = 5;
            // 
            // textBoxANS2
            // 
            this.textBoxANS2.Location = new System.Drawing.Point(69, 64);
            this.textBoxANS2.Name = "textBoxANS2";
            this.textBoxANS2.Size = new System.Drawing.Size(100, 20);
            this.textBoxANS2.TabIndex = 6;
            // 
            // textBoxANS3
            // 
            this.textBoxANS3.Location = new System.Drawing.Point(69, 90);
            this.textBoxANS3.Name = "textBoxANS3";
            this.textBoxANS3.Size = new System.Drawing.Size(100, 20);
            this.textBoxANS3.TabIndex = 7;
            // 
            // textBoxANS4
            // 
            this.textBoxANS4.Location = new System.Drawing.Point(69, 116);
            this.textBoxANS4.Name = "textBoxANS4";
            this.textBoxANS4.Size = new System.Drawing.Size(100, 20);
            this.textBoxANS4.TabIndex = 8;
            // 
            // textBoxRIGHT
            // 
            this.textBoxRIGHT.Location = new System.Drawing.Point(306, 76);
            this.textBoxRIGHT.Name = "textBoxRIGHT";
            this.textBoxRIGHT.Size = new System.Drawing.Size(100, 20);
            this.textBoxRIGHT.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Название Теста";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Вопрос 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Вопрос 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Вопрос 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Вопрос 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Правильный";
            // 
            // QuestAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 195);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRIGHT);
            this.Controls.Add(this.textBoxANS4);
            this.Controls.Add(this.textBoxANS3);
            this.Controls.Add(this.textBoxANS2);
            this.Controls.Add(this.textBoxANS1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Name = "QuestAdd";
            this.Text = "QuestAdd";
            this.Load += new System.EventHandler(this.QuestAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxANS1;
        private System.Windows.Forms.TextBox textBoxANS2;
        private System.Windows.Forms.TextBox textBoxANS3;
        private System.Windows.Forms.TextBox textBoxANS4;
        private System.Windows.Forms.TextBox textBoxRIGHT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}