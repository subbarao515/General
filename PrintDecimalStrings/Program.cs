using System;
using System.Collections;
using System.Collections.Generic;
namespace PrintDecimalStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Decimal number");
            int count=Convert.ToInt16(Console.ReadLine());
            Driver(count);

        }

        static void Driver(int numDigit)
        {
           
           Helper(numDigit,"");

        }
        static void Helper(int numDigit,string soFar)
        {
             if (numDigit == 0)
            {
                Console.WriteLine(soFar);
            }
            else
            {
              for(int choice=0;choice<=9;choice++)
             {
              Helper(numDigit-1,soFar+choice.ToString());
             }
                
            }

        }
    }
}
