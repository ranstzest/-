using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Medium
{
    class Program
    {
        public static void Answer()
        {
            
            int[] ArList = { 1, 5, 10, 50, 100, 500, 1000, 5000, 5000 };//0-7
            string[] RoList = { "I", "V", "X", "L", "C", "D", "M", "_V", "W", "_?" };

            string inputAnswer2 = Console.ReadLine();
            string pattern_math= @"([\+\-\*\/])";
            string[] inputNum = Regex.Split(inputAnswer2, pattern_math);

            for (int l = 0; l < 3; l++)
            {
                string pattern = @"^\d+$";                                  //正則規律10以內+-/*共三位元
                string Input = inputNum[l];
                bool inputIsNumber = Regex.IsMatch(Input, pattern);
                if (inputIsNumber==false)
                {
            /*此下跟轉換器一樣*/  int output2 = 0;
                                string j = Input;
                                for (int i = 7; i >= 0; i--)
                                {
                                    string pattern4 = RoList[i + 1] + RoList[i] + RoList[i + 1];
                                    string pattern5 = RoList[i] + RoList[i + 2];
                                    j = j.Replace(pattern5, pattern4);
                                    string pattern2 = RoList[i] + RoList[i] + RoList[i] + RoList[i];
                                    string pattern3 = RoList[i] + RoList[i + 1];
                                    j = j.Replace(pattern3, pattern2);
                                }
                                string ArrList = "IVXLCDMW";
                                for (int i = 0; i < j.Length; i++)
                                {
                                    output2 = output2 + ArList[ArrList.IndexOf(j.Substring(i, 1))];
                                }
            /*此上跟轉換器一樣*/  inputNum[l]=Convert.ToString(output2);                                                
                }
                l++; //0跳2
            }

            int _X = Convert.ToInt32(inputNum[0]);
            int _Y = Convert.ToInt32(inputNum[2]);
            int _Z=0;
            switch (Convert.ToChar(inputNum[1]))
            {
                case '+':
                    _Z = _X + _Y;
                    break;
                case '-':
                    _Z = _X - _Y;
                    break;
                case '*':
                    _Z = _X * _Y;
                    break;
                case '/':
                    _Z = _X / _Y;
                    break;
                default:
                    Console.WriteLine("無法計算");
                    break;
            }
            /*此下跟轉換器一樣*/  string output = "";
                                int n = Convert.ToInt32(_Z);
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
                                        string pattern3 = RoList[i] + RoList[i + 1];
                                        output = output.Replace(pattern2, pattern3);
                                        string pattern4 = RoList[i + 1] + RoList[i] + RoList[i + 1];
                                        string pattern5 = RoList[i] + RoList[i + 2];
                                        output = output.Replace(pattern4, pattern5);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("輸入的[數字]太大了");
            /*此上跟轉換器一樣*/  }
            if (output=="")
            {
                output = "zero";
            }
             Console.WriteLine(output);
        }
    }
}
