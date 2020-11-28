using System;

namespace NumbersPrintRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give a number");
            int num=Convert.ToInt32(Console.ReadLine());
            PrintNumbers(num);

        }

   public static void PrintNumbers(int number)
    {
           
          if(number==0)
          return;
          else
          {
           PrintNumbers(number-1);
           Console.WriteLine(number);
          }

    }
    }



   
}
