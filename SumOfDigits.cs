using System;
using System.Collections.Generic;
using System.Text;

namespace _4B_OOPS
{
    internal class SumOfDigits
    {
        public void SumofDigit()
        {
            Console.WriteLine("Enter Number :");
            int n = Convert.ToInt16(Console.ReadLine());
            int sum=0,num;
            while (n > 0)
            {
                num = n % 10;
                sum += num;
                n = n / 10;
            }
            Console.WriteLine("Sum of Digit is :"+sum);
        }
    }
}
