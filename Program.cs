/*
Program: Gregorian Calendar Calculator
Description: A program to calculate wether a year is common or leap.
Author: Adrian Sanchez (EC1939656)
Company: Edinburgh College
Version: 1.0
 */
using System;
using System.Runtime.CompilerServices;

namespace GregorianCalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Leap Year Calculator***");
            Console.WriteLine("Please type a year (Ex: 1748)");
            string num = Console.ReadLine();
            int year = Convert.ToInt32(num);

            if (year < 1582)
            {
                Console.WriteLine("This year is not within the Gregorian Calendar");
            }
            else
            {
                if (year % 4 != 0)
                {
                    Console.WriteLine("This is a common year");
                }
                else if (year % 100 != 0)
                {
                    Console.WriteLine("This is a leap year");
                }
                else if (year % 400 != 0)
                {
                    Console.WriteLine("This is a common year");
                }
                else
                {
                    Console.WriteLine("This is a leap year");
                }
            }
           
        }
    }
}
