using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_task3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Для расссчета расстояния между точками  введите значение координаты Х для первой точки:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("укажите значение координаты У для первой точки:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("укажите значение координаты Х для второй точки:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("укажите значение координаты Y для второй точки:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($" Расстояние между точками 1 и 2 составляет {r}");
            Console.ReadKey();

        }
    }
}
