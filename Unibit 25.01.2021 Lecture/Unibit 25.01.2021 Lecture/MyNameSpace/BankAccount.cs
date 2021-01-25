using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unibit_25._01._2021_Lecture.MyNameSpace
{
    public class BankAccount
    {
        private string owner;
        private decimal balance;
        private double rate;
        
        public string Owner { 
            get { 
                return this.owner; }
            set { 
                 this.owner = value; }
        }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }
        public double Rate {
            get
            {
                return this.rate;
            }
            set
            {
                this.rate = value;
            }
        } public BankAccount(string owner, decimal balance, double rate)
        {

            this.owner = owner;
            this.balance = balance;
            this.rate = rate;
        }

        public void PrintData()
        {
            Console.WriteLine("The Owner is: {0} The Balance is: {1} The Rate is: {2}", this.owner, this.balance, this.rate);
        }
       
        public decimal Deposit(decimal amount)
        {
            return this.balance = this.balance + amount;
        }
        public decimal Withdraw(decimal amount)
        {
            return this.balance = this.balance - amount;
        }
        public decimal AddIntrate()
        {
            return this.balance = this.balance + balance * (decimal) this.rate;
        }
    }
}
