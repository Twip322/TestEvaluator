namespace UserInterface
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Testing = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Testing
            // 
            this.Testing.Location = new System.Drawing.Point(190, 113);
            this.Testing.Name = "Testing";
            this.Testing.Size = new System.Drawing.Size(114, 27);
            this.Testing.TabIndex = 0;
            this.Testing.Text = "Тестирование";
            this.Testing.UseVisualStyleBackColor = true;
            this.Testing.Click += new System.EventHandler(this.Testing_Click);
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(190, 171);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(114, 29);
            this.Test.TabIndex = 1;
            this.Test.Text = "Тесты";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 342);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.Testing);
            this.Name = "FormMain";
            this.Text = "Обработчик знаний";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Testing;
        private System.Windows.Forms.Button Test;
    }
}

