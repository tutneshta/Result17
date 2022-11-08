using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Result17
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var account = new Account
            {
                Balance = 1010,
                Type = "Обычный"
            };

            ICalculateInterest calculateInterestBase = new BaseAccountCalculator();
            calculateInterestBase.CalculateInterest(account);

            AccountInfoToConsole accountInfo = new AccountInfoToConsole();
            accountInfo.PrintAccountInfo(account);

            //ICalculateInterest calculateInterestSalary = new SalaryAccountCalculator();
            //calculateInterestSalary.CalculateInterest(account);
            //accountInfo.PrintAccountInfo(account);

            Console.ReadLine();
        }
    }
}