using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Fibonacci_Sequence_and_Golden_Ratio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Sequence and Golden Ratio");     
            double f, f1, f2, f3, ratio;
            f1 = 0;
            f2 = 1;
            f3 = 0;
            ratio = 0;
            f = Convert.ToDouble(Console.ReadLine()); 
            for (int i = 1; i < f+1; i++)                   //使用for
            {
                
                f3 = f1 + f2;                               //下一個自冪數
                Console.Write("F({0})={1}, ratio={2}\n",i,f2,ratio);
                ratio = ((f1 + f2) / f2);                   //根據範例第一次ratio為0，
                f1 = f2;
                f2 = f3;

            }
            Console.ReadLine();
        }
    }
}
