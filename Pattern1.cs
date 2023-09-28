using System;
using System.Collections.Generic;
using System.Text;

namespace _4B_OOPS
{
    internal class Pattern1
    {
        public void PrintPattern()
        {
            int n = Convert.ToInt16(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
