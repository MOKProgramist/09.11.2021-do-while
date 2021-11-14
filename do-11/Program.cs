using System;

namespace do_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double s, t, i = 0, let = 5;

            Console.Write("Введите сумму вклада: ");
            s = int.Parse(Console.ReadLine()); // считываем сумму

            Console.Write("Введите % вклада: ");
            t = int.Parse(Console.ReadLine()); // считываем процент

            do
            {
                var sum = (s / 100) * t; // высчитываем сумму накопления на конец года
                s += sum; // добавляем процент к текущему депозиту

                Console.WriteLine($"\tСумма на конец {i} года: {s:0.00}");

                i++; // +1
            } while (i <= let);

            Console.ReadLine(); // задерживаем
        }
    }
}
