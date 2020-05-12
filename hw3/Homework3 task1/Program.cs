using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_task1
{
    struct Complex
    {
        public double im;
        public double re;
        // Сложение двух комплексных чисел
        public Complex Plus (Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        //Разность комплексных чисел
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        // Произведение двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        //  Деление комплексных чисел
        public Complex Quotient(Complex x)
        {
            Complex y;
            y.im = (x.re * im + re * x.im) / Math.Pow(x.re, 2) + Math.Pow(x.im, 2);
            y.re = (re * x.re + x.im * im) / Math.Pow(x.re, 2) + Math.Pow(x.im, 2);
            return y;
        }
        public string ToString ()
        {
            return re + "+" + im + "i";
        }
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
            Console.WriteLine("Задание а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры." +
            "б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса." +
            "в) Добавить диалог с использованием switch демонстрирующий работу класса.");

          
                Complex complex1;
                
            complex1.re = 1;
                complex1.im = 1;

                Complex complex2;
                complex2.re = 2;
            complex2.im = 2;

                Complex result = complex1.Plus(complex2);
                Console.WriteLine(result.ToString());
              
            Complex result1 = complex1.Multi(complex2);
            Console.WriteLine(result1.ToString());

            Complex result2 = complex1.Minus(complex2);
            Console.WriteLine(result2.ToString());

            Complex result3 = complex1.Quotient(complex2);
            Console.WriteLine(result3.ToString());
            Console.ReadKey();

        }
      
    }
}
