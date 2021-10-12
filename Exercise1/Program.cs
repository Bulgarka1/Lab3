using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine($"Введите занчение х: ");
            x = Convert.ToDouble(Console.ReadLine());

            if (x >= 2.5)
            {
                y = 5 * x - 2;
            }
            else if (-250 < x && x < 2.5)
            {
                y = 3 + x;
            }
            else
            {
                y = 2 * x + 1;
            }
            Console.WriteLine($"Полученное значение y: {y} ");
        }
    }
}
//16. y = {5x − 2, x ≥ 2.5
         // 3 + x, − 250 < x < 2.5
         // 2x + 1, x ≤ −250