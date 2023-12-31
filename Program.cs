﻿using System;

namespace _4B_OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1)Find Duplicates in an Array \n2)Unique Elements in an Array \n3)Frequency Of Elements in an Array \n4)Max And Min Element in Array \n5)Pattern1  \n6)Pattern2 \n7)Reverse String \n8)Sum of Digits of Number \n9)Sum oF each Row In Matrix");
            int option = Convert.ToInt16(Console.ReadLine());
            while (true)
            {
                switch (option)
                {
                    case 1:
                        DuplicateElements duplicate = new DuplicateElements();
                        duplicate.FindDuplicateElements();
                        break;
                    case 2:
                        UniqueElements unique = new UniqueElements();
                        unique.checkUniqueElements();
                        break;
                    case 3:
                        FrequencyOfArrayElements frequency = new FrequencyOfArrayElements();
                        frequency.FrequencyofElements();
                        break;
                    case 4:
                        MaxAndMinElement max = new MaxAndMinElement();
                        max.FindMaxAndMin();
                        break;
                    case 5:
                        Pattern1 pattern1 = new Pattern1();
                        pattern1.PrintPattern();
                        break;
                    case 6:
                        Pattern2 pattern = new Pattern2();
                        pattern.PrintPattern2();
                        break;
                    case 7:
                        ReverseWord reverse = new ReverseWord();
                        reverse.ReverseString();
                        break;
                    case 8:
                        SumOfDigits sum = new SumOfDigits();
                        sum.SumofDigit();
                        break;
                    case 9:
                        SumOfEachRow sumOf = new SumOfEachRow();
                        sumOf.checkSum();
                        break;
                }
            }
        }
    }
}
