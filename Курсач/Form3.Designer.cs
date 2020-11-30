namespace Курсач
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Enter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Bx_ic = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Bx_ic)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(109, 65);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(188, 22);
            this.Login.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(109, 101);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(188, 22);
            this.Password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.checkBox1.Location = new System.Drawing.Point(35, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Запомнить";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Enter.Location = new System.Drawing.Point(177, 133);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(120, 31);
            this.Enter.TabIndex = 5;
            this.Enter.Text = "Войти";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(31, 6);
            this.label4.MaximumSize = new System.Drawing.Size(0, 16);
            this.label4.MinimumSize = new System.Drawing.Size(0, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Авторизация";
            // 
            // Bx_ic
            // 
            this.Bx_ic.Image = ((System.Drawing.Image)(resources.GetObject("Bx_ic.Image")));
            this.Bx_ic.Location = new System.Drawing.Point(2, 1);
            this.Bx_ic.Name = "Bx_ic";
            this.Bx_ic.Size = new System.Drawing.Size(24, 24);
            this.Bx_ic.TabIndex = 26;
            this.Bx_ic.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_exit.Image = global::Курсач.Properties.Resources.exit1;
            this.btn_exit.Location = new System.Drawing.Point(308, 0);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exit.MaximumSize = new System.Drawing.Size(33, 33);
            this.btn_exit.MinimumSize = new System.Drawing.Size(33, 33);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(33, 33);
            this.btn_exit.TabIndex = 25;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(31, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Введите адрес электронной почты";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 174);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bx_ic);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 190);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 190);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bx_ic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
#pragma warning disable CS0108 // Член скрывает унаследованный член: отсутствует новое ключевое слово
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox Bx_ic;
        private System.Windows.Forms.Label label3;
#pragma warning restore CS0108 // Член скрывает унаследованный член: отсутствует новое ключевое слово
    }
}