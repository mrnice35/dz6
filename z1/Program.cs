using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести с клавиатуры предложение");
            string startString = Console.ReadLine();//вводим строку
            string[] stringArray = startString.Split();//разбиваем в массив отдельных слов
            string a = "";//нулевая строка
            int b = 0;//нулевое значение
            foreach (string s in stringArray)// для каждого элемента строки в массиве выполнить действие(переменная s принимает значение поочереди
            {
                if (s.Length > b)//если длинна слова больше b,то b принимает значение слова 
                {
                    b = s.Length;//b принимает значение длины наибольшего слова 
                    a = s;// строка принимает значение большего слова
                }
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
