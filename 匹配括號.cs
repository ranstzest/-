using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Program
{
    class Program
    {
        public static void Answer()
        {
            Console.Write("Input: s=");
            string easyInput = Console.ReadLine();
            bool InputBool = true;
            for (int i = 0; i < easyInput.Length/2; i++)
            {
            easyInput = Regex.Replace(easyInput, @"(\(\)|\[\]|\{\})*", "");
            }
            if (easyInput!="")
            {
                InputBool = false;
            }
            Console.WriteLine("Output:{0}", InputBool);
        }
    }
}
