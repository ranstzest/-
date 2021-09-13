using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace ASCII碼轉換器
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nASCII碼轉換器");
            Console.WriteLine("Input a character then press Enter:");  //int為ASCII
            string inputString = Console.ReadLine();
            if (inputString.Length>1)
            {
               Console.WriteLine("Invalid input");
            }
            else
            {
                byte[] inputAscii = Encoding.ASCII.GetBytes(inputString);

                Console.WriteLine("{0}'s ascii code is {1}", inputString, inputAscii[0]);
                Console.Write("This character is a");

                if (inputAscii[0]>=48 & inputAscii[0] <=57)         //*48-57  |0-9  number      
                     { Console.Write(" number");}
                else if (inputAscii[0] >= 65 & inputAscii[0] <= 90) //*65-90  |大寫 upper letter
                     { Console.Write("n upper letter");}
                else if (inputAscii[0] >= 97 & inputAscii[0] <= 122)//*97-122 |小寫 lower letter 
                     { Console.Write(" lower letter");}
                else                                                //*Symbol
                     {Console.Write(" Symbol");}             
            }
            Console.ReadLine();
        }
    }
}
