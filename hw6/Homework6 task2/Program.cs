using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_task2
{
    public delegate double MinFunc(double x);
    class Program
    {
        public static double FunсPow2(double x)
        {
            return Math.Pow(x, 2);
        }

        public static double FunсPow3(double x)
        {
            return 10 - Math.Pow(x, 3);
        }

        public static double FuncSin(double x)
        {
            return Math.Sin(x);
        }

        public static double FuncCos(double x)
        {
            return Math.Cos(x);
        }

        public static void SaveFunc(string fileName, double a, double b, double h, MinFunc F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }

        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = br.ReadDouble();
                if (d < min) min = d;
            }
            br.Close();
            fs.Close();
            return min;
        }
        static void Menu()
        {
            Console.WriteLine("Рассчет минимального значения из представленных функций на заданном отрезке от а до b:");
            Console.WriteLine("1. F = x^2");
            Console.WriteLine("2. F = 10 - x^3");
            Console.WriteLine("3. F = sin(x)");
            Console.WriteLine("4. F = cos(x)");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2. Модифицировать программу нахождения минимума функции так," +
                "чтобы можно было передавать функцию в виде делегата." +
"а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и" +
"на каком отрезке находить минимум." +
"б) Используйте массив(или список) делегатов, в котором хранятся различные функции." +
"в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений.Пусть она" +
"возвращает минимум через параметр.)");


            Menu();
            int choose = 0;
            bool flag;
            do
            {
                try
                {
                    flag = false;
                    Console.WriteLine("Выберите функцию:");
                    choose = Convert.ToInt32(Console.ReadLine());
                    if (choose != 1 && choose != 2 && choose != 3 && choose != 4)
                    {
                        Console.WriteLine("Введите только 1, 2, 3 или 4:");
                        flag = true;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Неверный формат данных:");
                    Console.WriteLine(ex.Message);
                    flag = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Неправильное значение:");
                    Console.WriteLine(ex.Message);
                    flag = true;
                }
            }
            while (flag);
            Console.WriteLine("Ведите точку начала отрезка:");
            double begin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите точку конца отрезка:");
            double end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите шаг:");
            double step = Convert.ToInt32(Console.ReadLine());
            MinFunc[] funcArray = new MinFunc[] { FunсPow2, FunсPow2, FuncSin, FuncCos };
            SaveFunc("data.bin", begin, end, step, funсArray[choose - 1]);
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();
        }
    }
}
