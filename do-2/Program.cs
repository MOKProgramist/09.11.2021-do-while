using System;

namespace do_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y; // переменные 
            x = 1; // начальное значение

            do
            {
                y = Math.Pow(Math.E, x / 3); // функция

                Console.WriteLine($"y = {y:0.00} x = {x}"); // вывод и форматирование числа
                x++; // шаг +1 
            } while (x <= 6); // условие

            Console.ReadLine(); // задерживаем консоль
        }
    }
}
