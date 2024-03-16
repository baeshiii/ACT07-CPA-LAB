using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch07Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance, interestRate, targetBalance;
            Console.WriteLine("What is your current balance?");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current annual interest rate (in %)?");
            interestRate = Convert.ToDouble(Console.ReadLine()) / 100.0;
            Console.WriteLine("What balance would you like to have?");
            targetBalance = Convert.ToDouble(Console.ReadLine());

            int totalYears = 0;
            while (balance < targetBalance)
            {
                balance *= (1 + interestRate);
                ++totalYears;
            }

            Console.WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")} you'll have a balance of {balance}.");
            Console.ReadKey();

        }
    }
}
