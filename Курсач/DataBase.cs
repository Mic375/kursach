using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
     static class DataBase
    {
        public static string NameFile; //путь к файлу списков
        public static int countLines; // переменная для чтения файла по строкам
        public static string Fullpath = null; // путь к прикрепленному файлу
        public static string LoginFail = "..\\Login\\Login.txt";
        public static string Login = null;
        public static string password = null;
    }
}
