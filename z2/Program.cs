using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести с клавиатуры предложение");
            string startString = Console.ReadLine();//вводим строку
            string a = "";//нулевая строка
            startString = startString.Replace(" ",a);
            string s1 = "";
            
            for (int i = startString.Length-1; i >=0; i--)
            {
                s1+=startString[i];
                
            }
            Console.WriteLine(s1);
            if (startString==s1)
                Console.WriteLine("Это палиндром");
            else
            {
                Console.WriteLine("Это не палиндром");
            }

            Console.ReadKey();

        }
    }
}
