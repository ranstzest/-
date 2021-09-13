using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Number_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*********第一題**********/
            Console.WriteLine("第一題：Number Triangle\n");
            Console.Write("請輸入數字：");
            string inputNum = Console.ReadLine();
            string pattern = @"^\d+$";
            bool InputTest1 = Regex.IsMatch(inputNum, pattern);
            if (InputTest1==true)
            {
                int x=Convert.ToInt32(inputNum);                
                char sp = Convert.ToChar(" ");
                for (int i = 1; i < x+1; i++)
                {
                    string numLine = "";
                    for (int j = 1; j < i+1; j++)
                        {
                        numLine = numLine + j;
                        }                   
                    Console.Write(numLine.PadLeft(x,sp));
                    numLine = "";
                    for (int k = x-1;k>0; k--)
                    {
                        if (k != 0&&k<i){ 
                        numLine = numLine + k;
                }
            }
                    Console.Write(numLine);
                    Console.Write("\n");
                }      

            }
            else { Console.WriteLine("輸入錯誤，僅限正整數\n"); }
        }
    }
}
