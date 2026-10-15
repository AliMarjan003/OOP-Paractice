using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class Bankaccount
    {
        double balance;
        public double Balance
        {
            get { return balance; }
        }
        internal void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be more than 0!");
                {

                }
            }
            else
            {
                balance += amount;
            }
        }
        internal void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("With amount more than 0!");
            }
            else if (amount > balance)
            {
                throw new ArgumentException("Insufficient Balance");
            }
            else
            {
                balance-=amount;
            }
        }
    }
}
