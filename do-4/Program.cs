using System;

namespace do_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, max, n; // переменные
            x = -2; max = 0; n = 0; // начальное значение
            
            do
            {
                if (x == 0)
                {
                    Console.WriteLine("Деление на ноль");
                }
                else
                {
                    y = (((x * 2) + 5) / (2 * x)); // функция 
                    max = y > max ? y : max; // проверяем максимум

                    if (y % 2 == 0 && y % 3 == 0) n += 1; // четность на 2 и 3

                    Console.WriteLine($"x = {x} y = {y:0.0}");
                };
                x += 0.5; // шаг 
            } while (x <= 1);
            y = (((max * 2) + 5) / (2 * max));
            Console.WriteLine($"Максимальное значение y = {y:0.0} при x = {max},\nКоличество y кратным двум и трем: {n}");
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
