using System;

namespace do_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, s, i, t, n; // переменные
            i = 1; s = 0; t = 0; 

            Console.Write("Введите количествл чисел: ");
            n = int.Parse(Console.ReadLine()); // количество вводов

            do
            {
                Console.Write($"Введите число {i}: ");
                x = int.Parse(Console.ReadLine()); // текущее число

                if (x % 2 == 0)
                {
                    t ++; // четные числа +1
                    s += x; // сумма четных чисел
                }
                i++; // шаг цикла
            } while (i <= n);

            Console.WriteLine($"Четных чисел: {t} Их сумма: {s} Их среднее: {s / t:0.0}");
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
