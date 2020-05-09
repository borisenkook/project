using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_task5
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
            Console.WriteLine("Задание 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает," +
                "нужно ли человеку похудеть, набрать вес или все в норме;" +
                "б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.");

            Console.WriteLine("Для расссчета индекса массы тела укажите Ваш рост в метрах:");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Укажите Ваш вес в килограммах:");
            double m = Convert.ToDouble(Console.ReadLine());

            double imb = m / Math.Pow(h, 2);
            //if (imb <= 18.5)
           // {
                double addm = Math.Pow(h, 2) * 18.5 - m;
           // }
           // else if (imb >= 25)
           // {
                double redm = m - Math.Pow(h, 2) * 25;
                //Console.WriteLine($"Срочно принимайте меры! Вам нужно сбросить {redm}  кг до нормы");
                //Console.ReadKey();
           // }

            int imb1 = Convert.ToInt32(imb);   
                switch (imb1)
            {
                case 16:
                case 17:
                case 18:
                    Console.WriteLine("У Вас недостаточная масса тела!");
                    Console.WriteLine($"Для нормализации веса Вам нужно набрать {Math.Round (addm, 1)}  кг.");
                    break;
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                    Console.WriteLine("Ваш вес в норме, так держать!");
                    break;
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                    Console.WriteLine("У Вас избыточная масса тела, стадия предожирения!");
                    Console.WriteLine($"Для нормализации веса Вам нужно сбросить {Math.Round(redm, 1)} кг.");
                    break;
                case 31:
                case 32:
                case 33:
                case 34:
                case 35:
                    Console.WriteLine("У Вас избыточная масса тела, стадия ожирения!");
                    Console.WriteLine($"Срочно принимайте меры! Для нормализации веса Вам нужно сбросить {Math.Round(redm, 1)} кг.");

                    break;
                case 36:
                case 37:
                case 38:
                case 39:
                case 40:
                    Console.WriteLine("У Вас избыточная масса тела, стадия резкого ожирения!");
                    Console.WriteLine($"Срочно принимайте меры! Для нормализации веса Вам нужно сбросить + {Math.Round(redm, 1)}  + кг.");
                    
                    break;
                default:
                    Console.WriteLine("У Вас серьезные проблемы!");
                    Console.WriteLine($"Срочно обратитесь к врачу");
                    break;
                }
            Console.ReadKey();

        }
    }
}
