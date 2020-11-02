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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string boxselekt(int selectedIndex)
        {
            
            switch (selectedIndex)
            {
                case 0:
                    DataBase.NameFile = "..\\Списки\\1Курс.txt";
                    break;
                case 1:
                    DataBase.NameFile = "..\\Списки\\2Курс.txt";
                    break;
                case 2:
                    DataBase.NameFile = "..\\Списки\\3Курс.txt";
                    break;
                case 3:
                    DataBase.NameFile = "..\\Списки\\4Курс.txt";
                    break;
                case 4:
                    DataBase.NameFile = "..\\Списки\\Преп.txt";
                    break;
            }
            return (DataBase.NameFile);
        }
        public void Box_com_gr_SelectedIndexChanged(object sender, EventArgs e)
        {
            Box_com_gr.DropDownStyle = ComboBoxStyle.DropDownList;
            string selectedState = Box_com_gr.SelectedItem.ToString();  //MessageBox.Show(selectedState);
            int selectedIndex = Box_com_gr.SelectedIndex;
            DataBase.NameFile = boxselekt(selectedIndex);
            Box_sp.Text = File.ReadAllText(DataBase.NameFile);
            DataBase.selectedIndex = selectedIndex;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int selectedIndex = Box_com_gr.SelectedIndex;
            string Namefail;
            Namefail = boxselekt(selectedIndex);
            StreamWriter save = new StreamWriter(Namefail);
            save.WriteLine(Box_sp.Text);
            save.Close();
        }
    }
}
