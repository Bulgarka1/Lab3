using System;

namespace Задание_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //для натурального числа k  напечатать фразу "Мы нашли к грибов в лесу", согласовав окончание слова "грибов" с числом к.
            int fungus;
            Console.WriteLine($"введите кол-во грибов:");
            fungus = Convert.ToInt32(Console.ReadLine());
            string x = "Мы нашли ";
            string y = "в лесу.";
            string z = "";
            if (fungus > 10 && fungus < 21)
            {
                z = "грибов";
            }
            else if (fungus == 1 || fungus % 10 == 1) ;
            {
                z = "гриб";
            }
            if (fungus > 1 && fungus < 5 || fungus % 10 > 1 && fungus % 10 < 5)
            {
                z = "гриба";
            }
            Console.WriteLine($"{x} {fungus} {z} {y}");
            }          
        }
    }

