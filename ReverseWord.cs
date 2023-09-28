using System;
using System.Collections.Generic;
using System.Text;

namespace _4B_OOPS
{
    internal class ReverseWord
    {
        public void ReverseString()
        {
            string s1 = Console.ReadLine();
            string s2 = "";
            int i = s1.Length-1;
            while (i >= 0)
            {
                s2 += s1[i--];
            }
            Console.WriteLine("Reverse string is :"+s2);
        }
    }
}
