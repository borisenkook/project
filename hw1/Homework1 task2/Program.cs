using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Для расссчета индекса массы тела укажите Ваш рост в метрах:");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Укажите Ваш вес в килограммах:");
            double m = Convert.ToDouble(Console.ReadLine());

            double I = m / Math.Pow(h, 2);
            Console.WriteLine($" Индекс массы Вашего тела составляет {I}");
            Console.ReadKey();


        }
    }
}
