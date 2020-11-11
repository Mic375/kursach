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
            this.btn_av = new System.Windows.Forms.Button();
            this.Box_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_openList = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.Bx_ic = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.Bx_File_condition = new System.Windows.Forms.PictureBox();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Bx_ic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bx_File_condition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Box_send
            // 
            this.Box_send.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box_send.Location = new System.Drawing.Point(90, 98);
            this.Box_send.Multiline = true;
            this.Box_send.Name = "Box_send";
            this.Box_send.Size = new System.Drawing.Size(549, 26);
            this.Box_send.TabIndex = 0;
            this.Box_send.TextChanged += new System.EventHandler(this.Box_send_TextChanged);
            // 
            // Box_theme
            // 
            this.Box_theme.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box_theme.Location = new System.Drawing.Point(90, 145);
            this.Box_theme.Multiline = true;
            this.Box_theme.Name = "Box_theme";
            this.Box_theme.Size = new System.Drawing.Size(549, 26);
            this.Box_theme.TabIndex = 1;
            this.Box_theme.TextChanged += new System.EventHandler(this.Box_theme_TextChanged);
            // 
            // Box_opis
            // 
            this.Box_opis.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box_opis.Location = new System.Drawing.Point(12, 196);
            this.Box_opis.Multiline = true;
            this.Box_opis.Name = "Box_opis";
            this.Box_opis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Box_opis.Size = new System.Drawing.Size(627, 225);
            this.Box_opis.TabIndex = 2;
            this.Box_opis.TextChanged += new System.EventHandler(this.Box_opis_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_send.Location = new System.Drawing.Point(411, 427);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(87, 32);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Отправить";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_add_File
            // 
            this.btn_add_File.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_File.Location = new System.Drawing.Point(12, 427);
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
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.75F);
            this.label1.Location = new System.Drawing.Point(8, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Адресс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.75F);
            this.label2.Location = new System.Drawing.Point(8, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тема";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.75F);
            this.label3.Location = new System.Drawing.Point(9, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Письмо";
            // 
            // btn_av
            // 
            this.btn_av.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_av.Location = new System.Drawing.Point(217, 427);
            this.btn_av.Name = "btn_av";
            this.btn_av.Size = new System.Drawing.Size(82, 32);
            this.btn_av.TabIndex = 13;
            this.btn_av.Text = "Тест";
            this.btn_av.UseVisualStyleBackColor = true;
            this.btn_av.Click += new System.EventHandler(this.btn_av_Click);
            // 
            // Box_Name
            // 
            this.Box_Name.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box_Name.Location = new System.Drawing.Point(90, 53);
            this.Box_Name.Multiline = true;
            this.Box_Name.Name = "Box_Name";
            this.Box_Name.Size = new System.Drawing.Size(549, 26);
            this.Box_Name.TabIndex = 14;
            this.Box_Name.TextChanged += new System.EventHandler(this.Box_Name_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.75F);
            this.label6.Location = new System.Drawing.Point(9, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Имя";
            // 
            // btn_openList
            // 
            this.btn_openList.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_openList.Location = new System.Drawing.Point(531, 427);
            this.btn_openList.Name = "btn_openList";
            this.btn_openList.Size = new System.Drawing.Size(108, 32);
            this.btn_openList.TabIndex = 19;
            this.btn_openList.Text = "Открыть Списки";
            this.btn_openList.UseVisualStyleBackColor = true;
            this.btn_openList.Click += new System.EventHandler(this.btn_openList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label4.Location = new System.Drawing.Point(36, 10);
            this.label4.MaximumSize = new System.Drawing.Size(0, 16);
            this.label4.MinimumSize = new System.Drawing.Size(0, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Рассылка";
            // 
            // Bx_ic
            // 
            this.Bx_ic.Image = ((System.Drawing.Image)(resources.GetObject("Bx_ic.Image")));
            this.Bx_ic.Location = new System.Drawing.Point(12, 5);
            this.Bx_ic.Name = "Bx_ic";
            this.Bx_ic.Size = new System.Drawing.Size(24, 24);
            this.Bx_ic.TabIndex = 22;
            this.Bx_ic.TabStop = false;
            this.Bx_ic.Click += new System.EventHandler(this.Bx_ic_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_exit.Image = global::Курсач.Properties.Resources.exit1;
            this.btn_exit.Location = new System.Drawing.Point(626, 1);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exit.MaximumSize = new System.Drawing.Size(33, 33);
            this.btn_exit.MinimumSize = new System.Drawing.Size(33, 33);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(33, 33);
            this.btn_exit.TabIndex = 21;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Bx_File_condition
            // 
            this.Bx_File_condition.Location = new System.Drawing.Point(102, 427);
            this.Bx_File_condition.Name = "Bx_File_condition";
            this.Bx_File_condition.Size = new System.Drawing.Size(32, 32);
            this.Bx_File_condition.TabIndex = 20;
            this.Bx_File_condition.TabStop = false;
            this.Bx_File_condition.Click += new System.EventHandler(this.Bx_File_condition_Click);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Курсач.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(668, 473);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Bx_ic);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.Bx_File_condition);
            this.Controls.Add(this.btn_openList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Box_Name);
            this.Controls.Add(this.btn_av);
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
            this.MaximumSize = new System.Drawing.Size(684, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(684, 489);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bx_ic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bx_File_condition)).EndInit();
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
        private System.Windows.Forms.Button btn_av;
        private System.Windows.Forms.TextBox Box_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_openList;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox Bx_File_condition;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox Bx_ic;
        private System.Windows.Forms.Label label4;
    }
}

