namespace Курсач
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Box_send = new System.Windows.Forms.TextBox();
            this.Box_theme = new System.Windows.Forms.TextBox();
            this.Box_opis = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_add_File = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Box_mail = new System.Windows.Forms.TextBox();
            this.Box_pas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_av = new System.Windows.Forms.Button();
            this.Box_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Box_com_gr = new System.Windows.Forms.ComboBox();
            this.Box_sp = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_openList = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Box_send
            // 
            this.Box_send.Location = new System.Drawing.Point(90, 111);
            this.Box_send.Multiline = true;
            this.Box_send.Name = "Box_send";
            this.Box_send.Size = new System.Drawing.Size(549, 26);
            this.Box_send.TabIndex = 0;
            this.Box_send.TextChanged += new System.EventHandler(this.Box_send_TextChanged);
            // 
            // Box_theme
            // 
            this.Box_theme.Location = new System.Drawing.Point(90, 143);
            this.Box_theme.Multiline = true;
            this.Box_theme.Name = "Box_theme";
            this.Box_theme.Size = new System.Drawing.Size(549, 26);
            this.Box_theme.TabIndex = 1;
            this.Box_theme.TextChanged += new System.EventHandler(this.Box_theme_TextChanged);
            // 
            // Box_opis
            // 
            this.Box_opis.Location = new System.Drawing.Point(12, 196);
            this.Box_opis.Multiline = true;
            this.Box_opis.Name = "Box_opis";
            this.Box_opis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Box_opis.Size = new System.Drawing.Size(627, 194);
            this.Box_opis.TabIndex = 2;
            this.Box_opis.TextChanged += new System.EventHandler(this.Box_opis_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(411, 406);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(87, 32);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Отправить";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_add_File
            // 
            this.btn_add_File.Location = new System.Drawing.Point(12, 406);
            this.btn_add_File.Name = "btn_add_File";
            this.btn_add_File.Size = new System.Drawing.Size(84, 32);
            this.btn_add_File.TabIndex = 5;
            this.btn_add_File.Text = "Файл";
            this.btn_add_File.UseVisualStyleBackColor = true;
            this.btn_add_File.Click += new System.EventHandler(this.btn_add_File_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Адресс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тема";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Письмо";
            // 
            // Box_mail
            // 
            this.Box_mail.Location = new System.Drawing.Point(90, 15);
            this.Box_mail.Multiline = true;
            this.Box_mail.Name = "Box_mail";
            this.Box_mail.Size = new System.Drawing.Size(549, 26);
            this.Box_mail.TabIndex = 9;
            this.Box_mail.TextChanged += new System.EventHandler(this.Box_mail_TextChanged);
            // 
            // Box_pas
            // 
            this.Box_pas.Location = new System.Drawing.Point(90, 47);
            this.Box_pas.Multiline = true;
            this.Box_pas.Name = "Box_pas";
            this.Box_pas.Size = new System.Drawing.Size(549, 26);
            this.Box_pas.TabIndex = 10;
            this.Box_pas.TextChanged += new System.EventHandler(this.Box_pas_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Почта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Пароль";
            // 
            // btn_av
            // 
            this.btn_av.Location = new System.Drawing.Point(217, 406);
            this.btn_av.Name = "btn_av";
            this.btn_av.Size = new System.Drawing.Size(82, 32);
            this.btn_av.TabIndex = 13;
            this.btn_av.Text = "Тест";
            this.btn_av.UseVisualStyleBackColor = true;
            this.btn_av.Click += new System.EventHandler(this.btn_av_Click);
            // 
            // Box_Name
            // 
            this.Box_Name.Location = new System.Drawing.Point(90, 79);
            this.Box_Name.Multiline = true;
            this.Box_Name.Name = "Box_Name";
            this.Box_Name.Size = new System.Drawing.Size(549, 26);
            this.Box_Name.TabIndex = 14;
            this.Box_Name.TextChanged += new System.EventHandler(this.Box_Name_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Имя";
            // 
            // Box_com_gr
            // 
            this.Box_com_gr.FormattingEnabled = true;
            this.Box_com_gr.Items.AddRange(new object[] {
            "1 Курс",
            "2 Курс",
            "3 Курс",
            "4 Курс",
            "Преп"});
            this.Box_com_gr.Location = new System.Drawing.Point(697, 15);
            this.Box_com_gr.Name = "Box_com_gr";
            this.Box_com_gr.Size = new System.Drawing.Size(334, 21);
            this.Box_com_gr.TabIndex = 16;
            this.Box_com_gr.Text = "Списки";
            this.Box_com_gr.Visible = false;
            this.Box_com_gr.SelectedIndexChanged += new System.EventHandler(this.Box_com_gr_SelectedIndexChanged);
            // 
            // Box_sp
            // 
            this.Box_sp.Location = new System.Drawing.Point(697, 47);
            this.Box_sp.Multiline = true;
            this.Box_sp.Name = "Box_sp";
            this.Box_sp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Box_sp.Size = new System.Drawing.Size(334, 343);
            this.Box_sp.TabIndex = 17;
            this.Box_sp.Visible = false;
            this.Box_sp.TextChanged += new System.EventHandler(this.Box_sp_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(953, 406);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(78, 32);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "Принять";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_openList
            // 
            this.btn_openList.Location = new System.Drawing.Point(539, 406);
            this.btn_openList.Name = "btn_openList";
            this.btn_openList.Size = new System.Drawing.Size(100, 32);
            this.btn_openList.TabIndex = 19;
            this.btn_openList.Text = "Открыть Списки";
            this.btn_openList.UseVisualStyleBackColor = true;
            this.btn_openList.Click += new System.EventHandler(this.btn_openList_Click);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Курсач.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.btn_openList);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.Box_sp);
            this.Controls.Add(this.Box_com_gr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Box_Name);
            this.Controls.Add(this.btn_av);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Box_pas);
            this.Controls.Add(this.Box_mail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add_File);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.Box_opis);
            this.Controls.Add(this.Box_theme);
            this.Controls.Add(this.Box_send);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рассылка";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Box_send;
        private System.Windows.Forms.TextBox Box_theme;
        private System.Windows.Forms.TextBox Box_opis;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_add_File;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Box_mail;
        private System.Windows.Forms.TextBox Box_pas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_av;
        private System.Windows.Forms.TextBox Box_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_openList;
        public System.Windows.Forms.ComboBox Box_com_gr;
        public System.Windows.Forms.TextBox Box_sp;
        private System.Windows.Forms.BindingSource form1BindingSource;
    }
}

