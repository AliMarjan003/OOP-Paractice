using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class Marksmanager
    {
        int[] marks = new int[5];
        internal void Setmarks(int index, int value)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Marks must be between 0 and 100");
            }
            marks[index] = value;
        }
        internal int Getmarks(int index) { return marks[index]; }
        internal int Average(int subjectCount)
        {
            int total = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                total += marks[i];
            }
            return total / subjectCount;
        }
    }
}
