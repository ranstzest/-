using System;
using System.Text.RegularExpressions;
namespace Csharp
{
    class program
    {
        static void Main(string[] args)
        {
                  Console.WriteLine("Input formula:");
                  string pattern=@"([0-9])([\+\-\*\/])([0-9])";                           //正則規律10以內+-/*共三位元
                  string Input = Console.ReadLine();                                      //讀
                  bool InputTest =Regex.IsMatch( Input,pattern);                          //如果輸入不匹配正則布林值為非
                  if (Input.Length > 3 || InputTest == false)
                  {                            //字串長度>3或不匹配布林值則回傳錯誤
                      Console.WriteLine("type error");
                  }
                  else
                  {
                      int x1=Convert.ToInt32(Input.Substring(0,1));                       //取前值
                      int x2=Convert.ToInt32(Input.Substring(2,1));                       //取後值
                      string OperatorsChar=Input.Substring(1,1);                          //Operators
                      string fuckcase="+-*/";
                      int Operators=fuckcase.IndexOf(OperatorsChar);                      //選擇運算方式
                        switch(Operators)
                        {
                            case 0 :
                                Console.WriteLine(x1+x2);
                                break;
                            case 1:
                                Console.WriteLine(x1-x2);
                                break;
                            case 2:
                                Console.WriteLine(x1*x2);
                                break;
                            case 3:
                                Console.WriteLine((double)x1/x2);
                                break;
                             default:
                                Console.WriteLine("Error");                           
                                break;
                        };                         
                 };
          }
    }
}
