using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 台電電費計算
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


            Console.Write("請輸入用電度數: ");
            double power = double.Parse(Console.ReadLine());
            int price;
            int pay;
            int change;
            if (power >= 1001)
            {
                price = (int)(power * 6.41);
                Console.WriteLine("電費價格為{0}元 ", price);
            }
            else if (power >= 701)
            {
                price = (int)(power * 5.66);
                Console.WriteLine("電費價格為{0}元 ", price);
            }
            else if (power >= 501)
            {
                price = (int)(power * 4.80);
                Console.WriteLine("電費價格為{0}元 ", price);
            }
            else if (power >= 331)
            {
                price = (int)(power * 3.52);
                Console.WriteLine("電費價格為{0}元 ", price);
            }
            else if (power >= 121)
            {
                price = (int)(power * 2.38);
                Console.WriteLine("電費價格為{0}元 ", price);
            }
            else
            {
                price = (int)(power * 1.63);
                Console.WriteLine("電費價格為{0}元 ", price);
            }

            Console.Write("請輸入付款金額: ");
            pay = int.Parse(Console.ReadLine());
            if (pay >= price)
            {
                change = pay - price;
                Console.WriteLine("應找{0}元 ", change);
                int num;
                if (change >= 500)
                {
                    num = change / 500;
                    Console.WriteLine("500元紙鈔{0}張", num);
                    change = change % 500;
                }
                if (change >= 100)
                {
                    num = change / 100;
                    Console.WriteLine("100元紙鈔{0}張", num);
                    change = change % 100;
                }
                if (change >= 10)
                {
                    num = change / 10;
                    Console.WriteLine("10元硬幣{0}枚", num);
                    change = change % 10;
                }
                if (change >= 1)
                {
                    num = change / 1;
                    Console.WriteLine("1元硬幣{0}枚", num);
 
                }
            }
            else
            {
                Console.WriteLine("付款金額不足");
            }
            Console.ReadLine();
        }
    } 
}
