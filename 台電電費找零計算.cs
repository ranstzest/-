using System;

namespace 台電電費找零計算
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入用電度數: ");
            double power = double.Parse(Console.ReadLine());
            int price;
            int pay;
            int change;
            if (power >= 1001)
            {
                price = (int)(power * 6.41);
                Console.WriteLine("電費價格為{0}元 ",price);
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
                if (change >= 1000)
                {
                    num = change / 1000;
                    Console.WriteLine("1000元紙鈔{0}張", num);
                    change = change % 1000;
                }
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
                if (change >= 50)
                {
                    num = change / 50;
                    Console.WriteLine("50元硬幣{0}枚", num);
                    change = change % 50;
                }
                if (change >= 10)
                {
                    num = change / 10;
                    Console.WriteLine("10元硬幣{0}枚", num);
                    change = change % 10;
                }
                if (change >= 5)
                {
                    num = change / 5;
                    Console.WriteLine("5元硬幣{0}枚", num);
                    change = change % 5;
                }
                if (change >= 1)
                {
                    num = change / 1;
                    Console.WriteLine("1元硬幣{0}枚", num);
                    change = change % 1;
                }
            }
            else
            {
                Console.WriteLine("付款金額不足");
            }
        }
    }
}
