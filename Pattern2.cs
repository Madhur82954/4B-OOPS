using System;
using System.Collections.Generic;
using System.Text;

namespace _4B_OOPS
{
    internal class Pattern2
    {
        public void PrintPattern2()
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < 2 * (n - i) - 1; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < 2 * i + 1; k++)
                {
                    if (k == 0 || k == 2 * i || i == n - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
