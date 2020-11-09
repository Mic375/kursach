namespace Курсач
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_save = new System.Windows.Forms.Button();
            this.Box_sp = new System.Windows.Forms.TextBox();
            this.Box_com_gr = new System.Windows.Forms.ComboBox();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(268, 403);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(78, 32);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "Принять";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Box_sp
            // 
            this.Box_sp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box_sp.Location = new System.Drawing.Point(12, 44);
            this.Box_sp.MaximumSize = new System.Drawing.Size(334, 343);
            this.Box_sp.MinimumSize = new System.Drawing.Size(334, 343);
            this.Box_sp.Multiline = true;
            this.Box_sp.Name = "Box_sp";
            this.Box_sp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Box_sp.Size = new System.Drawing.Size(334, 343);
            this.Box_sp.TabIndex = 20;
            // 
            // Box_com_gr
            // 
            this.Box_com_gr.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box_com_gr.FormattingEnabled = true;
            this.Box_com_gr.Items.AddRange(new object[] {
            "1 Курс",
            "2 Курс",
            "3 Курс",
            "4 Курс",
            "Преп"});
            this.Box_com_gr.Location = new System.Drawing.Point(12, 12);
            this.Box_com_gr.Name = "Box_com_gr";
            this.Box_com_gr.Size = new System.Drawing.Size(334, 23);
            this.Box_com_gr.TabIndex = 19;
            this.Box_com_gr.Text = "Списки";
            this.Box_com_gr.SelectedIndexChanged += new System.EventHandler(this.Box_com_gr_SelectedIndexChanged);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Курсач.Form1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.Box_sp);
            this.Controls.Add(this.Box_com_gr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Списки";
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.TextBox Box_sp;
        public System.Windows.Forms.ComboBox Box_com_gr;
        private System.Windows.Forms.BindingSource form1BindingSource;
    }
}