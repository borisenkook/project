using System;

namespace Homework2_task1
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
            Console.WriteLine("Задание 1. Написать метод, возвращающий минимальное из трех чисел.");
            
            int x1, x2, x3;
            Console.WriteLine("Введите три целых числа.");

            Console.WriteLine("Введите первое число:");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите  третье число:");
            x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Максимальное число - {Max(x1, x2, x3)}");
            Console.ReadKey();
            }
        static int Max(int x1, int x2, int x3)
        {
            if (x1 < x2)
            {
                if (x2 < x3)
                {
                    return x3;
                }
                else
                {
                    return x2; ;
                }
            }
            else
            {
                if (x1 > x3)
                {
                    return x1; ;
                }
                else
                {
                    return x3; ;
                }
            }
        }
    }
}
