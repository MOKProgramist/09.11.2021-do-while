using System;

namespace do_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0; // переменные

            do
            {
                y = (3 * Math.Pow(x, 2)) - (1.8 * x);
                Console.WriteLine($"x = {x:0.0} y = {y:0.00}");
                x += 0.5; // шаг
            } while (x <= 5);

            Console.ReadLine(); // задерживаем консоль
        }
    }
}
