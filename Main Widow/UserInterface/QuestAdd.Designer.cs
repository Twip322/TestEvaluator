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
            this.textBoxName.Location = new System.Drawing.Point(151, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxANS1
            // 
            this.textBoxANS1.Location = new System.Drawing.Point(12, 47);
            this.textBoxANS1.Name = "textBoxANS1";
            this.textBoxANS1.Size = new System.Drawing.Size(100, 20);
            this.textBoxANS1.TabIndex = 5;
            // 
            // textBoxANS2
            // 
            this.textBoxANS2.Location = new System.Drawing.Point(12, 73);
            this.textBoxANS2.Name = "textBoxANS2";
            this.textBoxANS2.Size = new System.Drawing.Size(100, 20);
            this.textBoxANS2.TabIndex = 6;
            // 
            // textBoxANS3
            // 
            this.textBoxANS3.Location = new System.Drawing.Point(12, 99);
            this.textBoxANS3.Name = "textBoxANS3";
            this.textBoxANS3.Size = new System.Drawing.Size(100, 20);
            this.textBoxANS3.TabIndex = 7;
            // 
            // textBoxANS4
            // 
            this.textBoxANS4.Location = new System.Drawing.Point(12, 125);
            this.textBoxANS4.Name = "textBoxANS4";
            this.textBoxANS4.Size = new System.Drawing.Size(100, 20);
            this.textBoxANS4.TabIndex = 8;
            // 
            // textBoxRIGHT
            // 
            this.textBoxRIGHT.Location = new System.Drawing.Point(241, 73);
            this.textBoxRIGHT.Name = "textBoxRIGHT";
            this.textBoxRIGHT.Size = new System.Drawing.Size(100, 20);
            this.textBoxRIGHT.TabIndex = 9;
            // 
            // QuestAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 195);
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
    }
}