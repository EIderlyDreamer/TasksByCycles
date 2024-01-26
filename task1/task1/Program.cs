using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму депозита: ");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите кол-во месяцев: ");
            int months = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < months; i++)
            {
                deposit += deposit * 0.07M;
            }

            Console.WriteLine($"Конечный депозит составит: {deposit}");
            Console.ReadKey();
        }
    }
}