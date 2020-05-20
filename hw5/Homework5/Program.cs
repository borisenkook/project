using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Signature()
        {
            Console.WriteLine("Ольга Борисенко, Санкт-Петербург");
        }
        // создаем метод проверки логина LoginKontrol без регулярных выражений
        static public bool LoginKontrol(string a)
        {
            if ((a.Length < 2) || (a.Length > 10)) return false;
            if (char.IsDigit(a[0])) return false;
            for (int i = 1; i < a.Length; i++)
                if (!char.IsLetterOrDigit(a[i])) return false;
            return true;
        }

        // создаем метод проверки логина LoginKontrol на основе регулярных выражений
        static public bool LoginKontrolReg(string b)
        {
            if ((b.Length < 2) || (b.Length > 10)) return false;
            Regex regex = new Regex(@"^[A - Za - zА - Яа - яЁё] +[A - Za - zА - Яа - яЁё0 - 9]");
            return regex.IsMatch(b);
        }

        static void Main(string[] args)
        {
            Signature();
            Console.WriteLine("Задание 1. Создать программу, которая будет проверять корректность ввода логина."+
                 "Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,"+
                 "при этом цифра не может быть первой:"+
            "а) без использования регулярных выражений;"+
            "б) **с использованием регулярных выражений.");
                       
            //Вводим логин
            Console.WriteLine("Введите логин:");
            string login = Console.ReadLine();

            //Проверяем введенный логин методом LoginKontrol
            if (LoginKontrol(login)) Console.WriteLine("Результат проверки 1: Логин установлен правильно");
            else Console.WriteLine("Результат проверки 1: Логин не соответствует правилам");

            //Проверяем введенный логин методом LoginKontrolReg
            if (LoginKontrolReg(login)) Console.WriteLine("Результат проверки 2: Логин установлен правильно");
            else Console.WriteLine("Результат проверки 2: Логин не соответствует правилам");
            Console.ReadKey();
            
        }
    }
}
