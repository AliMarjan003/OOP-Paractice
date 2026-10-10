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
                throw new ArgumentException("Deposit amount more than 0 worth");
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
                throw new ArgumentException("withdraw amount more than 0 woth");
            }
            else if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient balance");
            }
            else
            {
                balance -= amount;
            }
        }
    }
}
