using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Specialized;
using System.Linq.Expressions;

namespace Курсач
{
    public partial class Form3 : Form
    {
        string[] lines = File.ReadAllLines(DataBase.LoginFail, Encoding.UTF8);
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form1 task = new Form1();
            task.Visible = false;
            if(lines[2]=="true")
            {
                checkBox1.Checked = true;
            }
            if (lines[0] != null && lines[1] != null && checkBox1.Checked == true)
            {
                Login.Text = lines[0];
                Password.Text = lines[1];
            }

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (Login.Text != "" && Password.Text != "")
            {
                if (checkBox1.Checked == true)
                {
                    lines[0] = Login.Text;
                    lines[1] = Password.Text;
                    lines[2] = "true";
                }
                else
                {
                    lines[0] = "1";
                    lines[1] = "1";
                    lines[2] = "1";
                }
                DataBase.Login = Login.Text;
                DataBase.password = Password.Text;
                File.WriteAllLines(DataBase.LoginFail, lines);
                this.Hide();
                Form1 task = new Form1();
                task.Show();
            }
            else
            {
                MessageBox.Show("Введите Логин и пароль", "Ошибка");
                MessageBox.Show("Если хотите посмотреть программу, то введите 'пробел' в оба поля", "Ошибка");
            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
