using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace GCD_and_LCM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GCD & LCM");
            Console.Write("Please enter num1:");
            int num1 = Convert.ToInt32( Console.ReadLine());
            int keyin1 = num1;
            Console.Write("Please enter num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int keyin2 = num2;
            
            string pattern = @"^\d+$";
            bool InputTest1 = Regex.IsMatch(Convert.ToString(keyin1), pattern);
            bool InputTest2 = Regex.IsMatch(Convert.ToString(keyin2), pattern);
            if (InputTest1 && InputTest2)
            {
                if (num2 > num1)                //找大小
                {
                    int r = num1;
                    num1 = num2;
                    num2 = r;
                }

                while (num1 % num2 != 0)        // input1:12, 8  ;input2  8,4 不執行
                {
                    int r = num1 % num2;        // r=4              
                    num1 = num2;                // 8               
                    num2 = r;                   // 4               <GCD 
                }
                int GCD = num2;
                int LCD = keyin1 * keyin2 / GCD;
                Console.WriteLine("THE GCD of " + keyin1 + " and " + keyin2 + " is " + GCD);
                Console.WriteLine("THE LCD of " + keyin1 + " and " + keyin2 + " is " + LCD);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Value Out of Range");
            }            
        }
    }
}
