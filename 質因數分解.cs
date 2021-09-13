using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace 質因數分解
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("請輸入一個整數");
            int num =Convert.ToInt32( Console.ReadLine());
            int num2 = num;
            int x = 2;
            string answer = "";
            while (num>=x)
            {
                if (num % x == 0)
                {
                    num = num / x;
                    answer = answer+x + "x";
                }
                else { x++;}
            }
            string input = answer;
            string pattern = "([0-9]*x)+";
            bool InputTest = Regex.IsMatch(input, pattern);
            if (InputTest)
            {
                answer = answer.Remove(answer.Length - 1);
                Console.WriteLine("{0}={1}", num2, answer);
            }
            else
            {
                answer = Convert.ToString( num2);
                Console.WriteLine("{0}={1}", num2, answer);
            }
            
            Console.ReadLine();
        }
    }
}
