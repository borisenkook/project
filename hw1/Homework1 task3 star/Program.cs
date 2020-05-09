using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_task3_star
{
    class Program
    {
        static double R(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow(y2 - y1, 2));
        }
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

            Console.WriteLine(value: $" Расстояние между точками 1 и 2 составляет" + R(x1, y1, x2, y2));
            Console.ReadKey();
        }
    }
}
