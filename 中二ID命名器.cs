using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace 中二ID命名器
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("中二 ID 命名器");
            Console.WriteLine("******************************************************");
            Console.WriteLine("*****************請輸入模式（純數字）*****************");
            Console.WriteLine("*  [1]：naming with prefix, postfix and infix        *");
            Console.WriteLine("*  [2]：naming with prefix and postfix               *");
            Console.WriteLine("*  [3]：naming with infix                            *");
            Console.WriteLine("*  [4]：naming without prefix, postfix and infix     *");
            Console.WriteLine("******************************************************");
            Console.WriteLine("Type:");
            string[] strArrPrefix   = new string[] { "0o", "乂☆", "\\", "↗", "＊*", "卍" };//0-5
            string[] strArrPostfix  = new string[] { "o0", "☆乂", "/", "↙", "*＊", "卍" };//As Postfix
            string[] strArrInfix    = new string[] { "a", "o", "x", "之", "★", "～", "‧"};//0-6
            string[] strArrFW       = new string[] { "小小", "元氣", "楓糖", "霸氣", "煞氣", "闇夜", "血" };//0-6
            string[] strArrSW       = new string[] { "糖", "漾", "戀果", "鮭魚", "鮪魚", "大閘蟹" };//0-5
            string type = Console.ReadLine();

            Random rnd = new Random();
            int NP = rnd.Next(0, 5); // Pre Post
            int NI = rnd.Next(0, 6); // Infix
            int NFW = rnd.Next(0, 6); // fw
            int NSW = rnd.Next(0, 5); // sw
            switch (type)
            {
                case "1":
                    Console.WriteLine(strArrPrefix[NP] + strArrFW[NFW] + strArrInfix[NI] + strArrSW[NSW] + strArrPostfix[NP]);
                    break;
                case "2":
                    Console.WriteLine(strArrPrefix[NP] + strArrFW[NFW] + strArrSW[NSW] + strArrPostfix[NP]);
                    break;
                case "3":
                    Console.WriteLine(strArrFW[NFW] + strArrInfix[NI] + strArrSW[NSW]);
                    break;
                case "4":
                    Console.WriteLine(strArrFW[NFW] + strArrSW[NSW]);
                    break;
                default:
                    Console.WriteLine("模式輸入錯誤（純數字1~4）");
                    break;
            }           
        }
    }
}
