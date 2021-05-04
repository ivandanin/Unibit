using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_46337_z
{
    public class CreditAccount : SavingsAccount
    {
        public CreditAccount(string name, decimal balance) 
            : base(name, balance)
        {
        }

        public void GetCredit(decimal creditAmount, Employee obj)
        {   
            if (obj.Age <=25 || obj.Age > 25 && obj.Age <=65)
            {
                if(obj.Client.Equals("client"))
                {
            decimal interestForClients = (decimal) ClientInterest.CLIENT;

                } else
                {
            decimal interestForNONClients = (decimal) ClientInterest.NONCLIENT;

                }

            } else
            {
                if(obj.Client.Equals("client"))
                {

            decimal interestForRetiredClients = (decimal)ClientInterest.CLIENT - 0.02m;
                } else
                {
            decimal interestForRetiredNONClients = (decimal)ClientInterest.NONCLIENT - 0.02m;

                }

            }
            decimal totalCreditAmount;
            totalCreditAmount = creditAmount + creditAmount * obj.Interest;
            Console.WriteLine($"The Credit amount is ${totalCreditAmount} and the person is {obj.FirstName}");
        }
    }
}
