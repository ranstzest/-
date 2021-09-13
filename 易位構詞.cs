using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace 易位構詞 //Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("第一題\n1:A\n2:B\n3:C\n\n第二題");
            //Anagram在沒有其他的加密下排序即可比對
            Console.WriteLine("Enter first word:");
            string inputFirWord = Console.ReadLine();
            Console.WriteLine("Enter second word:");
            string inputSecWord = Console.ReadLine();
            
            //刪空白
            inputFirWord = Regex.Replace(inputFirWord, @"\s", "");
            inputSecWord = Regex.Replace(inputSecWord, @"\s", "");

            //擷取字元
            string[] firWordArray = Regex.Split(inputFirWord, "");
            string[] secWordArray = Regex.Split(inputSecWord, "");

            //排序
            Array.Sort(firWordArray);
            Array.Sort(secWordArray);

            string a="";
            string b="";
            foreach (var item in firWordArray)
            {a = a + item;}
            foreach (var item in secWordArray)
            {b = b + item;}

            if (a==b)
            {Console.WriteLine("The words are anagrams.");}
            else
            {Console.WriteLine("The words are not anagrams.");}
            

            Console.Read();

        }
    }
}
