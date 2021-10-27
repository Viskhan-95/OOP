using System;

namespace DZ3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("Hello World!"));
        }


        public static string ReverseString(string str)
        {
            string newStr = string.Empty;

            for (int i = str.Length-1; i >= 0; i--)
            {
                newStr += str[i];
            }
            return newStr;
        }
    }
}
