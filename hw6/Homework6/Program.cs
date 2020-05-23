using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public delegate double Function1(double x);
    public delegate double Function2(double x, double a);

    class Program
    {
        public static void Table1(Function1 F, double x, double b)
        {
            Console.WriteLine("=======X=========Y========");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
        }

        public static void Table2(Function2 F, double x, double b, double a)
        {
            Console.WriteLine("=======X=========A==========Y========");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000}", x, a, F(x,a));
                x += 1;
            }
        }

        public static double MyFunction(double x)
        {
            return x * x * x;
        }

        public static double MyFunction2(double x, double a)
        {
            return a * Math.Pow(x, 2);
        }

        public static double MyFunction3(double x, double a)
        {
            return a * Math.Sin(x);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("задание 1.Изменить программу вывода функции так, чтобы можно было передавать" +
                "функции типа double(double, double). Продемонстрировать работу на функции с функцией a * x ^ 2 и" +
                "функцией a * sin(x).");

            Console.WriteLine("Таблица функции MyFunction:");
            Table1(new Function1(MyFunction), -2, 2);

            Console.WriteLine("Таблица функции Sin(x):");
            Table1(Math.Sin, -2, 2);

            Console.WriteLine("Таблица функции a*x^2:");
            Table2(MyFunction2, -2, 2, 3);

            Console.WriteLine("Таблица функции a*Sin(x):");
            Table2(MyFunction3, -2, 2, 3);

            Console.ReadLine();

        }
    }
}
