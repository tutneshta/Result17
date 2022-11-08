using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result17
{
    internal class AccountInfoToConsole : IAccountInfo
    {
        public void PrintAccountInfo(Account account)
        {
            Console.WriteLine($"Процентная ставка аккаунта \"{account.Type}\": {account.Interest}");
        }
    }
}