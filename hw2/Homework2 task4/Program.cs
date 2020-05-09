using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_task4
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
            Console.WriteLine("Задание 4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль." +
                " На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains)." +
                " Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль," +
                "программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.");

            int n = 0;

            while (n != 3)
            {
                Console.WriteLine("Введите логин:");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                string password = Console.ReadLine();
                n++;
                if (Autorization(login, password))
                {
                    Console.WriteLine("Добро пожаловать в программу!");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Логин или пароль введены неверно!");
                }
                
                }
            

            bool Autorization(string login, string password)
            {
                // string login0 = "Root";
                // string passvord0 = "GeekBrains";
                if (login == "Root" && password == "GeekBrains")
                {
                    return true;
                }
                else
                    return false;
            }
        }
    }
}
