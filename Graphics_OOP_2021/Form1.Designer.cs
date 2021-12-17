namespace Graphics_OOP_2021
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_refresh = new System.Windows.Forms.Button();
            this.rb_circle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_sandcart = new System.Windows.Forms.RadioButton();
            this.rb_cart = new System.Windows.Forms.RadioButton();
            this.rb_coalcart = new System.Windows.Forms.RadioButton();
            this.rb_rect = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 410);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(12, 430);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(60, 24);
            this.button_refresh.TabIndex = 5;
            this.button_refresh.Text = "refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // rb_circle
            // 
            this.rb_circle.AutoSize = true;
            this.rb_circle.Location = new System.Drawing.Point(6, 19);
            this.rb_circle.Name = "rb_circle";
            this.rb_circle.Size = new System.Drawing.Size(51, 17);
            this.rb_circle.TabIndex = 6;
            this.rb_circle.TabStop = true;
            this.rb_circle.Text = "Circle";
            this.rb_circle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_sandcart);
            this.groupBox1.Controls.Add(this.rb_cart);
            this.groupBox1.Controls.Add(this.rb_coalcart);
            this.groupBox1.Controls.Add(this.rb_rect);
            this.groupBox1.Controls.Add(this.rb_circle);
            this.groupBox1.Location = new System.Drawing.Point(819, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 145);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figure";
            // 
            // rb_sandcart
            // 
            this.rb_sandcart.AutoSize = true;
            this.rb_sandcart.Location = new System.Drawing.Point(6, 112);
            this.rb_sandcart.Name = "rb_sandcart";
            this.rb_sandcart.Size = new System.Drawing.Size(67, 17);
            this.rb_sandcart.TabIndex = 9;
            this.rb_sandcart.TabStop = true;
            this.rb_sandcart.Text = "Coal cart";
            this.rb_sandcart.UseVisualStyleBackColor = true;
            // 
            // rb_cart
            // 
            this.rb_cart.AutoSize = true;
            this.rb_cart.Location = new System.Drawing.Point(6, 65);
            this.rb_cart.Name = "rb_cart";
            this.rb_cart.Size = new System.Drawing.Size(75, 17);
            this.rb_cart.TabIndex = 8;
            this.rb_cart.TabStop = true;
            this.rb_cart.Text = "Empty cart";
            this.rb_cart.UseVisualStyleBackColor = true;
            // 
            // rb_coalcart
            // 
            this.rb_coalcart.AutoSize = true;
            this.rb_coalcart.Location = new System.Drawing.Point(6, 89);
            this.rb_coalcart.Name = "rb_coalcart";
            this.rb_coalcart.Size = new System.Drawing.Size(71, 17);
            this.rb_coalcart.TabIndex = 10;
            this.rb_coalcart.TabStop = true;
            this.rb_coalcart.Text = "Sand cart";
            this.rb_coalcart.UseVisualStyleBackColor = true;
            // 
            // rb_rect
            // 
            this.rb_rect.AutoSize = true;
            this.rb_rect.Location = new System.Drawing.Point(6, 42);
            this.rb_rect.Name = "rb_rect";
            this.rb_rect.Size = new System.Drawing.Size(72, 17);
            this.rb_rect.TabIndex = 7;
            this.rb_rect.TabStop = true;
            this.rb_rect.Text = "Rectange";
            this.rb_rect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(993, 466);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Draw figure";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.RadioButton rb_circle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_coalcart;
        private System.Windows.Forms.RadioButton rb_sandcart;
        private System.Windows.Forms.RadioButton rb_cart;
        private System.Windows.Forms.RadioButton rb_rect;
    }
}

