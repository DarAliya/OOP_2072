
namespace OOP_4
{
    partial class Form1
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
            this.date_text = new System.Windows.Forms.TextBox();
            this.month_text = new System.Windows.Forms.TextBox();
            this.year_text = new System.Windows.Forms.TextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.proverka_text = new System.Windows.Forms.Label();
            this.prazdnik_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // date_text
            // 
            this.date_text.Location = new System.Drawing.Point(238, 210);
            this.date_text.Name = "date_text";
            this.date_text.Size = new System.Drawing.Size(25, 22);
            this.date_text.TabIndex = 0;
            this.date_text.Text = "31";
            // 
            // month_text
            // 
            this.month_text.Location = new System.Drawing.Point(290, 210);
            this.month_text.Name = "month_text";
            this.month_text.Size = new System.Drawing.Size(101, 22);
            this.month_text.TabIndex = 1;
            this.month_text.Text = "12";
            // 
            // year_text
            // 
            this.year_text.Location = new System.Drawing.Point(431, 210);
            this.year_text.Name = "year_text";
            this.year_text.Size = new System.Drawing.Size(57, 22);
            this.year_text.TabIndex = 2;
            this.year_text.Text = "2021";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(303, 257);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 3;
            this.start_button.Text = "NEXT";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // proverka_text
            // 
            this.proverka_text.AutoSize = true;
            this.proverka_text.Location = new System.Drawing.Point(290, 345);
            this.proverka_text.Name = "proverka_text";
            this.proverka_text.Size = new System.Drawing.Size(0, 17);
            this.proverka_text.TabIndex = 4;
            // 
            // prazdnik_text
            // 
            this.prazdnik_text.AutoSize = true;
            this.prazdnik_text.Location = new System.Drawing.Point(314, 170);
            this.prazdnik_text.Name = "prazdnik_text";
            this.prazdnik_text.Size = new System.Drawing.Size(107, 17);
            this.prazdnik_text.TabIndex = 5;
            this.prazdnik_text.Text = "Праздника нет";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prazdnik_text);
            this.Controls.Add(this.proverka_text);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.year_text);
            this.Controls.Add(this.month_text);
            this.Controls.Add(this.date_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox date_text;
        private System.Windows.Forms.TextBox month_text;
        private System.Windows.Forms.TextBox year_text;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label proverka_text;
        private System.Windows.Forms.Label prazdnik_text;
    }
}

