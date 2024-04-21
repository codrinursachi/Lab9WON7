using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9WON7
{
    class SavingsAccount : BankAccount
    {
        readonly decimal interestRate;

        public SavingsAccount(string name, decimal interestRate) : base(name)
        {
            this.interestRate = interestRate;
            accountType = AccountType.economii;
        }

        public override void MakeDeposit(int sum)
        {
            base.MakeDeposit(sum);
            currentBalance *= (1 + interestRate);
        }

        public override void GetDescription()
        {
            base.GetDescription();
            Console.WriteLine($"Tip cont: {accountType} \nDobanda: {interestRate}");
        }
    }
}
