using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер таблицы: ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}