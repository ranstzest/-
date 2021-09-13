using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Reverse_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nReverse Number");
            Console.Write("\nEnter a number:");
            string numIn = Console.ReadLine();
            string numIn_pattern = @"^\d+$";
            string revNum = "";
            string allRevNum = "";
            bool numInRegex = Regex.IsMatch(numIn, numIn_pattern);
            while (numInRegex) 
            {
                revNum = "";
                int x = numIn.Length;
                for (int i = 1; i < x+1; i++)
                {
                    revNum = revNum + numIn.Substring( x- i, 1);
                    allRevNum= allRevNum+ numIn.Substring(x - i, 1);
                }
                Console.WriteLine("Reversed number:"+ revNum);
                Console.Write("Enter a number:");
                numIn = Console.ReadLine();
                numInRegex = Regex.IsMatch(numIn, numIn_pattern);
            }
            Console.WriteLine("A sequence of reversed number:"+allRevNum);
            Console.ReadLine();           
        }
    }
}
