using System;

namespace do_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i = 1, n = 0, t = 0;

            Console.Write($"Введите количество чисел: ");
            n = int.Parse(Console.ReadLine()); // количество 

            do
            {
                Console.Write($"Введите число {i}: ");
                x = int.Parse(Console.ReadLine()); // текущее число

                if (x > 0) t++; // проверка на положительность
                i++; // шаг +1
            } while (i <= n);

            Console.WriteLine($"Положительных чисел: {t}");
            Console.ReadLine(); // задерживаем
        }
    }
}
