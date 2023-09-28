using System;
using System.Collections.Generic;
using System.Text;

namespace _4B_OOPS
{
    internal class SumOfEachRow
    {
        public void checkSum()
        {
            int r = 0;
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[10,10];
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix is :");
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(" "+arr[i,j]);
                }
                Console.WriteLine("");
            }
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    r += arr[i, j];
                }
                Console.WriteLine(+i+" Row sum is : "+r);
                r = 0;
            }
        }
    }
}
