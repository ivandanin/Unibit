using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_46337_z
{
    public abstract class SavingsAccount
    {
        protected string owner;
        protected decimal balance;

        public SavingsAccount (string name, decimal balance)
        {
            this.owner = name;
            this.balance = balance;
        }
        public void GetCredit(decimal creditAmount, Employee obj)
        {
            
            decimal totalCreditAmount;
            totalCreditAmount = creditAmount + creditAmount * (decimal)0.08;
            Console.WriteLine($"The Credit amount is ${totalCreditAmount} and the person is {obj.FirstName}");
        }
    }
}
