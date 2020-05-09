using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_task4_star
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение числа a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение числа b:");
            int b = Convert.ToInt32(Console.ReadLine());

            b = a + b;
            a = b - a;
            b = b - a;

            Console.WriteLine(value: $"Значения переменных а и б поменялись местами: a = {a} b = {b}");
            Console.ReadKey();
        }
    }
}
