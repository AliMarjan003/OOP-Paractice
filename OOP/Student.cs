using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class Student1
    {
        int roll_no;
        internal int fee;
        internal void Data(int r, int f)
        {
            roll_no = r;
            fee = f;
        }
        internal void Show()
        {
            Console.WriteLine("Roll no is:{0}, fees is:{1}",roll_no, fee);
        }
    }
}
