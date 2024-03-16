using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch07Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance, interestRate, targetBalance;
            WriteLine("What is your current balance?");
            balance = Convert.ToDouble(ReadLine());
            WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + Convert.ToDouble(ReadLine()) / 100.0;
            WriteLine("What balance would you like to have?");
            targetBalance = Convert.ToDouble(ReadLine());
            int totalYears = 0, i;
            for (i = 1; balance < targetBalance; i++)
            {
                if (totalYears == 5)
                    break;

                balance *= interestRate;
                ++totalYears;

                if (totalYears == 5)
                    continue;
            }

            WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")} " +
                $"you'll have a balance of {balance}.");

            if (totalYears == 0)

                ReadLine();
        }
    }
}
