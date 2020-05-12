using System;

namespace Homework3
{
    class Complex
    {
        // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
        public double im;
        public double re;

        public Complex Plus(Complex x2)
        {
            Complex Result = new Complex
            {
                im = x2.im + im,
                re = x2.re + re
            };
            return Result;
        }
        //Разность комплексных чисел
        public Complex Minus(Complex x2)
        {
            Complex Result = new Complex
            {
                im = im - x2.im,
                re = re - x2.re
            };
            return Result;
        }
        // Произведение двух комплексных чисел
        public Complex Multi(Complex x2)
        {
            Complex Result = new Complex
            {
                im = re * x2.im + im * x2.re,
                re = re * x2.re - im * x2.im
            };
            return Result;
        }
        //  Деление комплексных чисел
        public Complex Quotient(Complex x2)
        {
            Complex Result = new Complex
            {
                im = (x2.re * im + re * x2.im) / Math.Pow(x2.re, 2) + Math.Pow(x2.im, 2),
                re = (re * x2.re + x2.im * im) / Math.Pow(x2.re, 2) + Math.Pow(x2.im, 2)
            };
            return Result;
        }
        public string ToString => re + "+" + im + "i";
    }

    class Program
    {
        static void Signature()
        {
          Console.WriteLine("Ольга Борисенко, Санкт-Петербург");
        }
            static void Main()
            {
                Signature();
                     
                Console.WriteLine("Задание 1.б) Дописать класс Complex, добавив методы вычитания и"+
                "произведения чисел. Проверить работу класса." +
                "в) Добавить диалог с использованием switch демонстрирующий работу класса.");

                Console.WriteLine("Введите первое комплексное число:");
                Complex Complex1 = new Complex();

                Console.WriteLine("Действительная часть:");
                Complex1.re = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Мнимая часть:");
                Complex1.im = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе комплексное число:");
                Complex Complex2 = new Complex();

                Console.WriteLine("Действительная часть:");
                Complex2.re = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Мнимая часть:");
                Complex2.im = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите действие, которое требуется выполнить с комплексными числами:");
            Console.WriteLine("Сложение - нажмите 1");
            Console.WriteLine("Вычитание - нажмите 2");
            Console.WriteLine("Умножение - нажмите 3");
            Console.WriteLine("Деление - нажмите 4");
            
            int act = Convert.ToInt16(Console.ReadLine());

            switch (act)
            {
                case 1:
                    Console.WriteLine(Complex1.Plus(Complex2).ToString);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine(Complex1.Minus(Complex2).ToString);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine(Complex1.Multi(Complex2).ToString);
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine(Complex1.Quotient(Complex2).ToString);
                    Console.ReadKey();
                    break;
            }
        }
    }
    
}
