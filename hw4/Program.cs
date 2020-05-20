using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Signature ()
        {
            Console.WriteLine("Ольга Борисенко, Санкт-Петербург");
        }
        static void Main()
        {
            Signature();
            Console.WriteLine("Задание 1. Дан целочисленный массив из 20 элементов. " +
                "Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно." +
                "Написать программу, позволяющую найти и вывести количество пар элементов массива," +
                "в которых хотя бы одно число делится на 3. В данной задаче под парой подразумевается" +
                "два подряд идущих элемента массива."+
                "Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.");

            //Объявили одномерный массив из 20 элементов
            int[] array = new int[20];

            // генерируем случайные числа
            Random rnd = new Random();
            int i;
            for (i = 0; i < 20; i++)
            {
                array[i] = rnd.Next(-10000,10000);
            }

            // Заполняем массив случайными числами
            for (i = 0; i < 20; i++)
                Console.Write (array[i] + "\t");

            // Считаем количество пар чисел, в которых хотя бы одно делится на 3
            int count = 0;
            for (i = 0; i < 19; i++)
                
            if ((array[i] % 3 == 0) || (array[i+1] % 3 == 0))
                  
            {
                    Console.WriteLine ($"{array[i]} и {array[i + 1]}"); 
                    count += 1;
                    i += 1;
            }
            Console.Write($"Количество пар элементов массива, в которых хотя бы одно число делится на 3 составляет {count}");
            Console.ReadKey();



        }
    }
}
