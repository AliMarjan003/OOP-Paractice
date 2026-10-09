using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal abstract class Payment
    {
        internal void Showreceipt()
        {
            Console.WriteLine("Processing payment");
        }
        internal abstract void Processpayment();
    }
    internal class Creditcardpayment : Payment
    {
        string cardnumber;
        double amount;
        public string Cardnumber
        {
            get { return cardnumber; }
            set { cardnumber = value; }
        }
        public double Amount
        {
            get { return  amount; }
            set
            {
                if(value>0)
                {
                    amount = value;
                }
                else
                {
                    Console.WriteLine("Amount must be positive");
                }
            }
        }
        internal override void Processpayment()
        {
            Console.WriteLine("Card number is:{0}, and amount charged from card is:{1}", Cardnumber, Amount);
        }
    }
    internal class Cashpayment: Payment
    {
        double amount;
        public double Amount
        {
            get { return amount; }
            set
            {
                if (value > 0)
                {
                    amount = value;
                }
                else
                {
                    Console.WriteLine("Amount must be positive");
                }
            }
        }
        internal override void Processpayment()
        {
            Console.WriteLine("Cash Payment of "+ Amount + " Received");
        }
    }
}