using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_task3
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
            Console.WriteLine("Задание 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
            Console.WriteLine("Введите несколько чисел, закончите последовательность 0:");

            int n = 1;
            int sum = 0;

            while (n != 0)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    if (n % 2 != 0)
                    {
                        sum = sum + n;
                    }
                }
            }
                Console.WriteLine($"Сумма  введенных нечетных положительных чисел составляет {sum}");
                Console.ReadKey();
            
        }
    } 
}
