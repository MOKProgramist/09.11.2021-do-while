using System;

namespace do_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y; // переменные
            x = 1; // начальное значение

            do
            {
                y = ((Math.Cos(x) - 1)/ (2 * x)); // функция 
                Console.WriteLine($"y = {y:0.00000} x = {x:0.0}"); 
                x += 0.2; // шаг
            } while (x <= Math.PI);
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
