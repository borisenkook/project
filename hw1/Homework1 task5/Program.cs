using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_task5
{
    class Program
    {
        // Борисенко О.К.
        // Задание 5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        // б) Сделать задание, только вывод организуйте в центре экрана
        // в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)

        static void Main()
        {
            Console.WriteLine(" Меня зовут Ольга Борисенко. Я живу в городе Санкт-Петербург.");

            string str = " Меня зовут Ольга Борисенко. Я живу в городе Санкт-Петербург.";
            Console.SetCursorPosition((Console.WindowWidth - str.Length) / 2, Console.WindowHeight / 2);
            Console.WriteLine(str);
            Console.WriteLine(Signature());
            Console.ReadKey();
        }
        static string Signature()
        {
            return "Ольга Борисенко, Санкт-Петербург";
        }
        
    }
}
