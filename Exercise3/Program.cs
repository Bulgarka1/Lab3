using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Король:{1}");
            Console.WriteLine($"Ладья:{2}");
            Console.WriteLine($"Ферзь:{3}");
            Console.WriteLine($"Слон:{4}");
            Console.WriteLine($"Конь:{5}");
            Console.WriteLine($"Пешка:{6}");

            int figure=int.Parse(Console.ReadLine());

            switch (figure)
            {
                case 1:
                    Console.WriteLine("Диагональ 4");
                    break;
                case 2:
                    Console.WriteLine("Диагональ 5");
                    break;
                case 3:
                    Console.WriteLine("Диагонали 3,6");
                    break;
                case 4:
                    Console.WriteLine("Диагонали 1,8");
                    break;
                case 5:
                    Console.WriteLine("Диагонали 2,7");
                    break;
                case 6:
                    Console.WriteLine("Диагонали 1-8");
                    break;
            }
        }
            
    }
}
//16. Пользователь задаёт название фигуры на шахматной доске, вывести номера вертикалей с этой фигурой.