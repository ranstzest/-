using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace 河內塔
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------------河內塔難題--------------");
            Console.WriteLine("這邊有三根柱子，上面有依大小放置的圓盤");
            Console.WriteLine("請試著一次移動一個盤子，將圓盤全部移到第三柱");
            Console.WriteLine("請注意大圓盤不能放在小圓盤之上");
            Console.WriteLine("輸入說明：");
            Console.WriteLine("[1]、[1]、[1]：柱子編號左至右");
            Console.WriteLine("[1][1]將左邊柱子最上面的盤子移到右邊最上面\n");

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("任務：請將柱[1]的盤子全部移到柱[3]");
            Console.WriteLine("　　柱[1]\t　　柱[2]\t　　柱[3]");
            Console.WriteLine("-----------------當前情況---------------");

            Console.WriteLine("　　｜　　\t　　｜　　\t　　｜　　");
            Console.WriteLine("　　■　　\t　　｜　　\t　　｜　　");
            Console.WriteLine("　 ■■　 \t　　｜　　\t　　｜　　");
            Console.WriteLine("　■■■　\t　　｜　　\t　　｜　　");
            Console.WriteLine(" ■■■■ \t　　｜　　\t　　｜　　");
            Console.WriteLine("■■■■■\t　　｜　　\t　　｜　　\n\t\t\t\tnext");

            string[] arr = { "0123459", "09", "09" };//設置9為底，運算不影響,0為無
            string _1,_2,_3 ;

            //補0
            arr[0] = arr[0].PadLeft(7, '0');
            arr[1] = arr[1].PadLeft(7, '0');
            arr[2] = arr[2].PadLeft(7, '0');

            //移除0
            _1 = Convert.ToString(Convert.ToInt32(arr[0]));
            _2 = Convert.ToString(Convert.ToInt32(arr[1]));
            _3 = Convert.ToString(Convert.ToInt32(arr[2]));


            int cur = 0;
            string answer = "0123459";
            int x = Convert.ToInt32(answer);
            bool right = false;
            while (right == false)
            {

                string input = Console.ReadLine();

                /*
                _A = Convert.ToString(Convert.ToInt32(A));
                _B = Convert.ToString(Convert.ToInt32(B));
                _C = Convert.ToString(Convert.ToInt32(C));
                */
                int inX = Convert.ToInt32(input.Substring(0, 1))-1 ;//兩個字串 分別是柱的編號
                int inY = Convert.ToInt32(input.Substring(1, 1))-1 ;
                int _X =Convert.ToInt32(arr[inX]);
                int _Y = Convert.ToInt32(arr[inY]);//兩輸入的柱目前情況

                int _1X =Convert.ToInt32(Convert.ToString(_X).Substring(0, 1));
                int _1Y = Convert.ToInt32(Convert.ToString(_Y).Substring(0, 1));//兩柱的第一個盤子數字

                if ((_1X>_1Y) || (_1X==_1Y))
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 2);
                    Console.WriteLine("\t\t\t  \tnext\n\t\t\t");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    /*cur = cur + 5;
                    Console.WriteLine("輸入錯誤 重新輸入  \n格式為2位數字不添加其他符號");*/
                }
                else //將替換數字
                {
                    _X =Convert.ToInt32(Convert.ToString(_X).Substring(1,Convert.ToString(_X).Length-1));
                    _Y= Convert.ToInt32(Convert.ToString(_1X)+ Convert.ToString(_Y));
                    arr[inX] = Convert.ToString(_X);
                    arr[inY] = Convert.ToString(_Y);
                    arr[inX] = arr[inX].PadLeft(7, '0');
                    arr[inY] = arr[inY].PadLeft(7, '0');

                    string[] arrbar = {
                        "　　｜　　",
                        "　　■　　",
                        "　 ■■　 ",
                        "　■■■　",
                        " ■■■■ ",
                        "■■■■■" };
                    Console.SetCursorPosition(0, Console.CursorTop - 8 - cur);
                    cur = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(arrbar[Convert.ToInt16(arr[j].Substring(i, 1))]+"\t");
                        }
                        Console.Write("\n");
                    }
                    Console.WriteLine("\t\t\t  \tnext\n\t\t\t");
                    Console.SetCursorPosition(0, Console.CursorTop-1);
                    if (arr[2]==answer)
                    {
                        Console.WriteLine("完美達成");
                        right = true;
                    }
                }
                
            }
            Console.ReadLine();
        }
    }
}
