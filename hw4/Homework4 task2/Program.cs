using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Homework4_task2
{

    class Program
    {
        static void Signature()
        {
            Console.WriteLine("Ольга Борисенко, Санкт-Петербург");
        }
        class StaticClass
        {
            // Создаем класс массивов
            int[] array;
            //Создаем конструктор массива 
            public StaticClass(int n, int min, int max)
            {
                this.array = new int[n];
                Random rnd = new Random();

                for (int i = 0; i < n; i++)
                {
                    array[i] = rnd.Next(min, max);
                }
            }
            public void conGetRez()
            {
                foreach (int element in array) // for (int i = 0; i < this.array.Length; i++)
                {
                    Console.WriteLine(element);
                }
            }
            // Метод подсчета количества пар чисел, в которых хотя бы одно делится на 
            public int getRezalt()
            {
                int count = 0;
                for (int i = 1; i < this.array.Length; i++)
                {
                    if ((array[i-1] % 3 == 0) || (array[i] % 3 == 0))
                    {
                        Console.WriteLine($"{array[i-1]} и {array[i]}");

                        count++;
                    }
                }
                return count;
            }



        }
         static void Main()
        {
            Signature();
            Console.WriteLine("Реализуйте задачу 1 в виде статического класса StaticClass;" +
            "а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;" +
            "б) *Добавьте статический метод для считывания массива из текстового файла." +
            "Метод должен возвращать массив целых чисел;" +
            "в)**Добавьте обработку ситуации отсутствия файла на диске.");


            {

                int n = 20;
                int min = -10000;
                int max = 10000;
                StaticClass a = new StaticClass(n, min, max);
                a.conGetRez();
                Console.Write($"Количество пар элементов массива, в которых хотя бы одно число делится на 3 составляет {a.getRezalt()}");
                Console.ReadKey();
            }
        }
    }
}