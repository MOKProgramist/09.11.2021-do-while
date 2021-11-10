using System;

namespace do_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, nextdigit;


            Console.Write("Введите число: ");
            num = int.Parse(Console.ReadLine()); // считываем число

            Console.Write("Число в обратном порядке: ");

            do
            {
                nextdigit = num % 10; // получаем последние число
                Console.Write(nextdigit); // выводим число
                num = num / 10;
            } while (num > 0); // пока x > 0

            Console.ReadLine(); // задерживаем консоль
        }
    }
}
