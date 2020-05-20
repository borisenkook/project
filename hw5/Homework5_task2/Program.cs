using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_task2
{
    class Message
    {
        string message;
        public  string TextMessage { 
            get { return this.message; }
            set { this.message = value; }
        } // объявляем автоматическое свойство 
    }
    class Program
    {
                
        static void Signature()
        {
            Console.WriteLine("Ольга Борисенко, Санкт-Петербург");
        }
        
        static void WordEqualLen(string mes, int len)// Выводим слова определенной длины
        {
            string[] words = mes.Split(' ');
            foreach (string word in words)
                if (word.Length == len)
                    Console.WriteLine(word);
        }
        static string WordDel(string mes, char a) // удаляем слова, заканчивающиеся на определенный символ
        {
            string[] words = mes.Split(' ');
            string newMes = "";
            foreach (string word in words)
                if (word[word.Length - 1] == 'a') newMes += word + " ";
                return newMes;
        }

        static string WordMax(string mes)
        {
            string[] words = mes.Split(' ');
            int max = 0;
            string wordMax = " ";
            foreach (string word in words)
                if (word.Length > max){ 
                    max = word.Length;
                    wordMax += word; 
                }
                return wordMax;
        }
                static void Main(string[] args)
        {
            Signature();
            Console.WriteLine("Задание 2. Разработать статический класс Message," +
                "содержащий следующие статические методы для обработки текста:" +
        "а) Вывести только те слова сообщения,  которые содержат не более n букв." +
        "б) Удалить из сообщения все слова, которые заканчиваются на заданный символ." +
        "в) Найти самое длинное слово сообщения." +
        "г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения." +
        "д) ***Создать метод, который производит частотный анализ текста.В качестве параметра" +
        "в него передается массив слов и текст, в качестве результата метод возвращает" +
        "сколько раз каждое из слов массива входит в этот текст." +
        "Здесь требуется использовать класс Dictionary.");

            Message mes = new Message();
            Console.WriteLine("Введите текст:");
            mes.TextMessage = Console.ReadLine();
            Console.WriteLine(mes.TextMessage);

            Console.WriteLine("Введите количество букв в слове:");
            int len = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Слова, в которых {len} букв:");
            WordEqualLen(mes.TextMessage, len);

            Console.WriteLine("Введите символ на конце слов, которые нужно удалить:");
            char a = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Отредактированная строка: {WordDel(mes.TextMessage, a)}");

      

            Console.WriteLine($"Самое длинное слово содержит: {WordMax(mes.TextMessage)} букв");
            Console.ReadKey();
        }
    }

}
