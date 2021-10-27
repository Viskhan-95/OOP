using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3._3
{
    class MailAddress
    {
        //Метод получения данных из файла
        public void ReadDataFromFile()
        {
            string line;
            StreamReader sr = new StreamReader("Data.txt");
            line = sr.ReadLine();

            while (line != null)
            {
                WriteDataFromFile(SearchMail(ref line).Trim());
                line = sr.ReadLine();
            }
            sr.Close();
        }


        //Метод записи данных в файла
        public void WriteDataFromFile(string email)
        {
            StreamWriter sw = new StreamWriter("Email.txt", true, System.Text.Encoding.Default);
            sw.WriteLine(email);
            sw.Close(); //Грамотно ли каждый раз открывать и закрывать поток? или лучше сделать массив string и оттуда записать в файл?
        }


        //Метод, выделяющий из строки адрес почты
        public string SearchMail(ref string date)
        {
            int characterNumber = 0;
            string email;

            for (int i = 0; i < date.Length; i++)
            {
                if(date[i] == '&')
                {
                    characterNumber = i;
                    break;
                }
            }

            email = date.Substring(characterNumber+1);
            return email;
        }
    }
}
