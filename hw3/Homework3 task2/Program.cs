using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_task2
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

            Console.WriteLine("Задание 2. а) С клавиатуры вводятся числа, пока не будет введен 0" +
            "(каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел."+
            "Сами числа и сумму вывести на экран, используя tryParse;" +
            "б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные." +
            "При возникновении ошибки вывести сообщение.Напишите соответствующую функцию");

            int num = 1;
            int sum = 0;
            Console.WriteLine("Введите последовательность чисел:");
            while (num != 0)
            {
                string input = Console.ReadLine();
                bool result = int.TryParse(input, out num);
                if (result == true)
                {
                    if (num > 0)
                    {
                        if (num % 2 != 0)
                        {
                            sum += num;
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Значение {input} признано ошибочным, в рассчете не учтено"); ;
                }
                }
                Console.WriteLine($"Сумма  введенных нечетных положительных чисел составляет {sum}");
                Console.ReadKey();

            
        }
    }
}


 