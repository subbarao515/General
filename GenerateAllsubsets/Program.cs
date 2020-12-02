using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace GenerateAllsubsets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter String to Generate substring");
            string sourcestring=Console.ReadLine();
            Driver(sourcestring);

        }

        static void Driver(string sourceString)
        {

            List<string> collector = new List<string>();
            Helper(sourceString, new StringBuilder(), 0, collector);
            for(int i=0;i< collector.Count;i++)
            {
                Console.WriteLine(collector[i].ToString());
            }
        }

        static void Helper(string sourceString, StringBuilder soFar, int index, List<string> collector)
        {
 if (index == sourceString.Length)
            {
                collector.Add(soFar.ToString());
                return;
            }
            else
            {
                Helper(sourceString, soFar, index + 1, collector);
                soFar.Append(sourceString.Substring(index,1));
                Helper(sourceString, soFar, index+ 1,collector);
                soFar.Remove(soFar.Length - 1,1);
            }

        }
    }
}
