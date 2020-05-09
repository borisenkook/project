using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_task2
{
    class Program
    {
        static void Signature()
        {
            Console.WriteLine("Ольга Борисенко, Санкт-Петербург");
        }
        static void Main()
        {
            Signature();
            Console.WriteLine("Задание 2. Написать метод подсчета количества цифр числа.");

            Console.WriteLine("Введите целое число:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Сумма цифр числа  {x} составляет {CountNum(x)}");
            Console.ReadKey();
        }
        static int CountNum(int x)
        {
            int count = 0;
            while (x != 0)
            {
                count++;
                x = x / 10;
            }
            return count;
        }
    }
}
