using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9WON7
{
    class InvestmentAccount : SavingsAccount
    {
        readonly int maturityDate;

        public InvestmentAccount(string name, decimal interestRate, int maturityDate) : base(name, interestRate)
        {
            this.maturityDate = maturityDate;
            accountType = AccountType.investitii;
        }

        public override void Withdraw(int sum)
        {
            if (DateTime.Now.Day < maturityDate)
            {
                Console.WriteLine("Nu se pot extrage banii inainte de termen");
                return;
            }

            base.Withdraw(sum);
        }

        public override void GetDescription()
        {
            base.GetDescription();
            Console.WriteLine($"Zi termen extragere: {maturityDate}");
        }
    }


}
