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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Box_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Box_pas_TextChanged(object sender, EventArgs e)
        {

        }

        private void Box_send_TextChanged(object sender, EventArgs e)
        {

        }

        private void Box_theme_TextChanged(object sender, EventArgs e)
        {

        }

        private void Box_opis_TextChanged(object sender, EventArgs e)
        {

        }

        private void Box_Name_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void btn_av_Click(object sender, EventArgs e) // Тестовая кнопка
        {
            Box_mail.Text = "ntcn.ntcn.00@inbox.ru";
            Box_Name.Text = "Test";
            Box_pas.Text = "Test123test456test789tes";
            Box_theme.Text = "Test";
            Box_opis.Text = "Test";
        }

        private void btn_add_File_Click(object sender, EventArgs e) // кнопка прикрепляет файл
        {
            
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "All files (*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                DataBase.Fullpath = file.FileName;
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {    
            string[] lines = File.ReadAllLines(DataBase.NameFile, Encoding.UTF8); // читает файл со списками построчно
            for (int i = 0; i < DataBase.countLines; i++)
            {
                try
                {
                    Box_send.Text = lines[i];                                                         // вставляет адресс в textbox
                    MailAddress from = new MailAddress(Box_mail.Text, Box_Name.Text);                 // отправитель - устанавливаем адрес и отображаемое в письме имя                                                                    
                    MailAddress to = new MailAddress(Box_send.Text);                                  // кому отправляем                                                         
                    MailMessage m = new MailMessage(from, to);                                        // создаем объект сообщения                                                                       
                    m.Subject = Box_theme.Text;                                                       // тема письма                                                                           
                    m.Body = Box_opis.Text;                                                           // текст письма                                                          
                    m.IsBodyHtml = true;                                                              // письмо представляет код html  
                    SmtpClient smtp = new SmtpClient("smtp.mail.ru");                                 // адрес smtp-сервера и порт, с которого будем отправлять письмо                                                                      
                    smtp.Credentials = new NetworkCredential(Box_mail.Text, Box_pas.Text);            // логин и пароль  
                    smtp.EnableSsl = true;
                    if (DataBase.Fullpath != null)
                    {
                        m.Attachments.Add(new Attachment(DataBase.Fullpath));
                    }
                    smtp.Send(m);                                                                     // Отправка мыла                                                                        
                    Console.Read();
                }
                catch (Exception Ситуация)
                {
                    MessageBox.Show(Ситуация.Message,
                    "Ошибка, удалите пустые строки", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_openList_Click(object sender, EventArgs e)
        {
            Form2 Tasklist = new Form2();
            Tasklist.Show();
            
        }
    }
}
