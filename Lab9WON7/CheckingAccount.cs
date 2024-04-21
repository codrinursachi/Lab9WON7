using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9WON7
{
    class CheckingAccount : BankAccount
    {
        const int maxOverdraft = -5000;

        public CheckingAccount(string name) : base(name)
        {
            accountType = AccountType.curent;
        }

        public override void Withdraw(int sum)
        {
            if (currentBalance - sum < maxOverdraft)
            {
                Console.WriteLine("Retragerea depaseste plafonul descoperirii de cont");
                return;
            }

            currentBalance -= sum;
        }

        public override void GetDescription()
        {
            base.GetDescription();
            Console.WriteLine($"Tip cont: cont {accountType}");
        }
    }
}
