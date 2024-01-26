using System;

namespace ProductOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите первое число (0-10): ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите второе число (0-10): ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 >= 0 && num1 <= 10 && num2 >= 0 && num2 <= 10)
                {
                    Console.WriteLine($"Произведение чисел {num1} и {num2} даёт: {num1 * num2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверное число.");
                }
            }

            Console.ReadKey();
        }
    }
}