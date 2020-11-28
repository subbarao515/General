using System;
using System.Collections.Generic;
namespace PossibleExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your string from");
            String strinput =Console.ReadLine();
            Console.WriteLine("Please enter targat value");
            int tarvalue=Convert.ToInt32(Console.ReadLine());
            GetExp(strinput,tarvalue);
        }
         
         public static void  GetExp(string str,int target)
         {
               List<string> res = new List<string>();
             GetExphelper(ref res, "", str, target, 0, 0, 0);
             for (int i = 0; i < res.Count; i++)
                Console.WriteLine(res[i]); 

         }
          
           public static void  GetExphelper(ref List<string> res,string curExp, string input, int target, int pos, int curVal, int last)
        {
            if (pos == input.Length)
            {
                if (curVal == target)
                {
                    res.Add(curExp);
                    return;
                }
            }

            for (int i = pos; i < input.Length; i++)
            {
                if (i != pos && input[pos] == '0')
                    break;
                string part = input.Substring(pos, i + 1 - pos);
                int cur = Convert.ToInt32(part);
                if (pos == 0)
                {
                    GetExphelper(ref res,curExp + part, input, target, i + 1, cur, cur);
                }

                else
                {
                    GetExphelper(ref res, curExp + "+" + part, input, target, i + 1, curVal + cur, cur);
                    GetExphelper(ref res, curExp + "-" + part, input, target, i + 1, curVal - cur, -cur);
                    GetExphelper(ref res, curExp + "*" + part, input, target, i + 1, curVal - last + last * cur, last * cur);
                }
            }

         
        }

    }
}
