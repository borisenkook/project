using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_task1
{
    //struct Complex
    //{
    //    public double im;
    //    public double re;
    //    // Сложение двух комплексных чисел
    //    public Complex Plus(Complex x)
    //    {
    //        Complex y;
    //        y.im = im + x.im;
    //        y.re = re + x.re;
    //        return y;
    //    }
    //    //Разность комплексных чисел
    //    public Complex Minus(Complex x)
    //    {
    //        Complex y;
    //        y.im = im - x.im;
    //        y.re = re - x.re;
    //        return y;
    //    }
    //    // Произведение двух комплексных чисел
    //    public Complex Multi(Complex x)
    //    {
    //        Complex y;
    //        y.im = re * x.im + im * x.re;
    //        y.re = re * x.re - im * x.im;
    //        return y;
    //    }
    //    //  Деление комплексных чисел
    //    public Complex Quotient(Complex x)
    //    {
    //        Complex y;
    //        y.im = (x.re * im + re * x.im) / Math.Pow(x.re, 2) + Math.Pow(x.im, 2);
    //        y.re = (re * x.re + x.im * im) / Math.Pow(x.re, 2) + Math.Pow(x.im, 2);
    //        return y;
    //    }
    //    public string ToString()
    //    {
    //        return re + "+" + im + "i";
    //    }
    //}

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

            Console.WriteLine("Выберите действие, которое требуется выполнить с комплексными числами:"+
                "Сложение - нажмите 1"+" /n " +
                "Вычитание - нажмите 2"+" / n" +
                "Умножение - нажмите 3" + "/ n " +
                "Деление - нажмите 4"); 
            //enum Actions { Plus, Minus, Multy, Quotient };

            int act = Convert.ToInt16(Console.ReadLine());
            Switch (act)

            {  
                case act.1:
                Complex result = Complex1.Plus(Complex2);
                Console.WriteLine(result.ToString());
                Console.ReadKey(); 
                break;
            }
                case action = "2":
            Complex result1 = Complex1 Minus(Complex2);
            Console.WriteLine(result.ToString());
                Console.ReadKey();
                break;
        }

        }
    }

    //Complex result = complex1.Plus(complex2);
    //Console.WriteLine(result.ToString());

    //Complex result1 = complex1.Multi(complex2);
    //Console.WriteLine(result1.ToString());

    //Complex result2 = complex1.Minus(complex2);
    //Console.WriteLine(result2.ToString());

    //Complex result3 = complex1.Quotient(complex2);
    //Console.WriteLine(result3.ToString());
    //Console.ReadKey();


    
    class Complex
    {
        // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
        public double im;
        public double re;

        public Complex Plus(Complex x2)
        {
            Complex Result = new Complex();
            Result.im = x2.im + im;
            Result.re = x2.re + re;
            return Result;
        }
        //Разность комплексных чисел
        public Complex Minus(Complex x2)
        {
            Complex Result1 = new Complex();
            Result1.im = im - x2.im;
            Result1.re = re - x2.re;
            return Result1;
        }
        // Произведение двух комплексных чисел
        public Complex Multi(Complex x2)
        {
            Complex Result2 = new Complex();
            Result2.im = re * x2.im + im * x2.re;
            Result2.re = re * x2.re - im * x2.im;
            return Result2;
        }
        //  Деление комплексных чисел
        public Complex Quotient(Complex x2)
        {
            Complex Result3 = new Complex();
            Result3.im = (x2.re * im + re * x2.im) / Math.Pow(x2.re, 2) + Math.Pow(x2.im, 2);
            Result3.re = (re * x2.re + x2.im * im) / Math.Pow(x2.re, 2) + Math.Pow(x2.im, 2);
            return Result3;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }



