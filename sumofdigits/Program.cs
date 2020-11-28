using System;

namespace sumofdigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide your input number");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of the digits "+sumofdigits(num));
        }

        public static int  sumofdigits(int number)
        {
           if(number==0)
           return 0;
           else
           {

              return (number%10+sumofdigits(number/10)); 
           }

        }

    }
}
