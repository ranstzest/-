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
            
            /*
            1   	I
            5	    V
            10	    X
            50	    L
            100	    C
            500	    D
            1,000	M
            5,000	_V
            */
            int[] ArList =    { 1 ,5  ,10 ,50 ,100,500,1000,5000,5000};//0-7
            string[] RoList = {"I","V","X","L","C","D", "M","_V", "W", "_?" }; //W為暫定數 為_V _?為用不到的值
            string pattern = @"^\d+$";                                  //正則規律10以內+-/*共三位元
            string Input = Console.ReadLine();                              
            bool inputIsNumber = Regex.IsMatch(Input, pattern);         // 判斷是否數字
/*N轉R*/    if (inputIsNumber)
            {
                string output = "";
                int n = Convert.ToInt32(Input);
                if (n <= 7414)
                {
                    string j = "";
                    for (int i = 7; i >= 0; i--)
                    {
                        //Console.WriteLine(i);
                        j = j + (n / ArList[i]);
                        n = n % ArList[i];
                    }
                    for (int i = 7; i >= 0; i--)
                    {
                        int k = Convert.ToInt32(j.Substring(7 - i, 1));
                        for (int y = 0; y < k; y++)
                        {
                            output = output + RoList[i];
                        }
                    }
                    for (int i = 7; i >= 0; i--)
                    {
                        string pattern2 = RoList[i] + RoList[i] + RoList[i] + RoList[i];
                        string pattern3 = RoList[i] + RoList[i+1];
                        output = output.Replace(pattern2, pattern3);
                        string pattern4 = RoList[i+1] + RoList[i] + RoList[i+1];
                        string pattern5 = RoList[i] + RoList[i + 2];
                        output = output.Replace(pattern4, pattern5);
                    }
                }
                else
                {
                Console.WriteLine("輸入的[數字]太大了");
                }
                Console.WriteLine(output);
            }
/*R轉N*/    else
            {
                int output=0 ;
                string j = Input;
                for (int i = 7; i >= 0; i--)
                {/*跟上面相反的順序*/
                    string pattern4 = RoList[i + 1] + RoList[i] + RoList[i + 1];
                    string pattern5 = RoList[i] + RoList[i + 2];
                    j = j.Replace(pattern5, pattern4);
                    string pattern2 = RoList[i] + RoList[i] + RoList[i] + RoList[i];
                    string pattern3 = RoList[i] + RoList[i + 1];
                    j = j.Replace(pattern3, pattern2);                    
                }
                string ArrList = "IVXLCDMW";
                for (int i = 0; i<j.Length;  i++)
                {
                    output= output+ ArList[ArrList.IndexOf(j.Substring(i, 1))];
                }
                Console.WriteLine(output);
            }
        }
    }
}
