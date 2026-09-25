using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class Book
    {
        string title;
        int price;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public int Price
        {
            get { return price;}
            set
            {
                if (value>0)
                {
                    price = value;
                }
                else
                {
                    Console.Write("Price mustbe positive");
                }
            }
        }
    }
    internal class Library
    {
        private Book[] books = new Book[4];
        public Book this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }
    }
}
