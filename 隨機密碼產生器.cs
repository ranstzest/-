using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 隨機密碼產生器
{
    class Program
    {
        static void Main(string[] args)
        {
            GetPassword();
        }
        static void GetPassword()
        {
            string rNumber = "0123456789";                      //10        宣告數字串
            string rUpChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";      //26        宣告大寫串
            string rLoChar = "abcdefghijklmnopqrstuvwxyz";      //26        宣告小寫串
            string rSymbol = "!@#$%^&*_+";                      //10        宣告符號串
            Random rnd = new Random();                          //產生隨機
            int rLength = rnd.Next(14, 20);                     //長度介於14~20之間
            string rType = "";                                  //密碼包含的類型
            string rPW = "";
            for (int i = 0; i < rLength - 4; i++)                 //賦予值-4 之後給予1~4 確保一種一個
            {
                int x = rnd.Next(1, 5);
                rType = rType + x;
            }                                                   //此時rTpye=密碼長度+類型
            for (int i = 1; i < 5; i++)
            {
                int x = rnd.Next(1, rType.Length);
                rType = rType.Insert(x, Convert.ToString(i));
            }
            for (int i = 0; i < rType.Length; i++)
            {   
                string rChar = "";
                switch (rType.Substring(i, 1))
                {
                    case "1":
                        rChar = rNumber.Substring(rnd.Next(0, 10),1);
                        break;
                    case "2":
                        rChar = rUpChar.Substring(rnd.Next(0, 26), 1);
                        break;
                    case "3":
                        rChar = rLoChar.Substring(rnd.Next(0, 26), 1);
                        break;
                    case "4":
                        rChar = rSymbol.Substring(rnd.Next(0, 10), 1);
                        break;
                    default:
                        break;
                }
                rPW = rPW + rChar;                                  //將值給予密碼
            }
            Console.WriteLine("Your random password is:");
            Console.WriteLine(rPW);
            Console.ReadLine();

        }
    } 
}
