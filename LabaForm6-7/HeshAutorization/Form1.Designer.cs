namespace HeshAutorization
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Autorization = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Registration = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Reg = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.Autorization.SuspendLayout();
            this.Registration.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Autorization);
            this.tabControl.Controls.Add(this.Registration);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(310, 396);
            this.tabControl.TabIndex = 0;
            // 
            // Autorization
            // 
            this.Autorization.Controls.Add(this.button1);
            this.Autorization.Controls.Add(this.label2);
            this.Autorization.Controls.Add(this.label1);
            this.Autorization.Controls.Add(this.textBox2);
            this.Autorization.Controls.Add(this.textBox1);
            this.Autorization.Location = new System.Drawing.Point(4, 22);
            this.Autorization.Margin = new System.Windows.Forms.Padding(2);
            this.Autorization.Name = "Autorization";
            this.Autorization.Padding = new System.Windows.Forms.Padding(2);
            this.Autorization.Size = new System.Drawing.Size(302, 370);
            this.Autorization.TabIndex = 0;
            this.Autorization.Text = "Авторизация";
            this.Autorization.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 223);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Авторизироваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите логин";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 177);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(104, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 105);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Registration
            // 
            this.Registration.Controls.Add(this.textBox6);
            this.Registration.Controls.Add(this.label6);
            this.Registration.Controls.Add(this.textBox7);
            this.Registration.Controls.Add(this.label7);
            this.Registration.Controls.Add(this.textBox8);
            this.Registration.Controls.Add(this.label8);
            this.Registration.Controls.Add(this.textBox5);
            this.Registration.Controls.Add(this.label5);
            this.Registration.Controls.Add(this.textBox4);
            this.Registration.Controls.Add(this.label4);
            this.Registration.Controls.Add(this.textBox3);
            this.Registration.Controls.Add(this.label3);
            this.Registration.Controls.Add(this.button_Reg);
            this.Registration.Location = new System.Drawing.Point(4, 22);
            this.Registration.Margin = new System.Windows.Forms.Padding(2);
            this.Registration.Name = "Registration";
            this.Registration.Padding = new System.Windows.Forms.Padding(2);
            this.Registration.Size = new System.Drawing.Size(302, 370);
            this.Registration.TabIndex = 1;
            this.Registration.Text = "Регистрация";
            this.Registration.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(92, 154);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(103, 20);
            this.textBox6.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Должность";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(92, 109);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(103, 20);
            this.textBox7.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Фамилия";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(92, 62);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(103, 20);
            this.textBox8.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Имя";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(92, 283);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '*';
            this.textBox5.Size = new System.Drawing.Size(103, 20);
            this.textBox5.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Повторите пароль";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(92, 238);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(103, 20);
            this.textBox4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Введите пароль";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 191);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(103, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Введите логин";
            // 
            // button_Reg
            // 
            this.button_Reg.Location = new System.Drawing.Point(100, 328);
            this.button_Reg.Margin = new System.Windows.Forms.Padding(2);
            this.button_Reg.Name = "button_Reg";
            this.button_Reg.Size = new System.Drawing.Size(92, 31);
            this.button_Reg.TabIndex = 0;
            this.button_Reg.Text = "Регистрация";
            this.button_Reg.UseVisualStyleBackColor = true;
            this.button_Reg.Click += new System.EventHandler(this.buttonRegClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 396);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.Autorization.ResumeLayout(false);
            this.Autorization.PerformLayout();
            this.Registration.ResumeLayout(false);
            this.Registration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Autorization;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage Registration;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Reg;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
    }
}

