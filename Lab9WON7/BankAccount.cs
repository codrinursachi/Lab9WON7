using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9WON7
{
    abstract partial class BankAccount(string name)
    {
        readonly Guid id = Guid.NewGuid();
        readonly string name = name;
        protected decimal currentBalance = 0;
        protected AccountType accountType;
        public virtual void MakeDeposit(int sum)
        {
            currentBalance += sum;
        }

        public virtual void Withdraw(int sum)
        {
            if (sum > currentBalance)
            {
                Console.WriteLine("Nu aveti suficienti bani in cont");
                return;
            }

            currentBalance -= sum;
        }

        public virtual void GetDescription()
        {
            Console.WriteLine($"Guid {id} \nNume: {name} \nSold: {currentBalance}");
        }
    }
}
