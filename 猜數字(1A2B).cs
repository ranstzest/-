using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace 猜數字(1A2B)
{
    class Program
    {
        static void Main(string[] args)
        {/* 
            Console.WriteLine("破解猜數字");
            Console.WriteLine("規則類型：數字不重複，可以0開頭");
            Console.WriteLine("輸入範例：請輸入[xAxB]，其他類型無法計算，請再次enter輸入");

            //Console.WriteLine("其他指令[Q]離開；[R]重新開始；準備好按任意鍵開始");

            Console.WriteLine("\n請輸入遊戲數字數量[1]~[9]");
            Random _亂數 = new Random();
            int _遊戲數字數量= Convert.ToInt32(Console.ReadLine());

            int[,] _答案庫 = new int[_遊戲數字數量, 10];

            string _本次猜測 = "";
            string[] _收集答案 = new string[] { };
            bool _正確=false;


            while (_正確 != true)
            {
                string _本次輸入題目 = "";
                string _本次輸入答案 = "";
                Console.Write("\n請輸入要輸入的數字：");
                _本次輸入題目 =  Console.ReadLine();
                Console.Write("\n請輸入本次猜測的結果：");
                _本次輸入答案 = Console.ReadLine();

                string 答案正則 = @"^(\d)A0B";
                string _正確判斷 = Regex.Match(_本次輸入答案, 答案正則).Groups[1].Value;

                if ( _遊戲數字數量== Convert.ToInt16(_正確判斷))
                {
                    Console.WriteLine("作答完畢");
                    _正確 = true;
                    break;
                }

                int _本次長度 = _本次輸入題目.Length;
                if (_本次長度 != _遊戲數字數量)
                {
                    Console.WriteLine("輸入字數錯誤");
                    break;
                }


                四位數邏輯，高階探索參考 https://www.shs.edu.tw/works/essay/2021/03/2021031208343948.pdf
                for (int i = 0; i < _本次長度; i++)
                {

                }
                _答案庫[_遊戲數字數量,1] = 0;
            }

            if (_正確 = true)
            {
                Console.WriteLine("遊戲結束");
            }
            Console.Read(); //結束時等待後再節數

            */
            Random ram = new Random();                          //設置隨機數
            Console.WriteLine("高階的猜數字");
            Console.WriteLine("電腦會產生1~10位數隨機數字，你的目的是盡可能最少的步數猜(算)出來");
            Console.Write("輸入要玩的數字數量[1]~[10]，輸入[0]為隨機數量：");
            int type = Convert.ToInt16( Console.ReadLine());    //根據輸入設置數字位數
            if (type == 0) {type= ram.Next(0,10); }             //如果是0則產生隨機碼
            Console.Write("\n數字是否要重複，[注意]如果重複的話6位數以上會變簡單；4位數以下會變難[Y][N]：");
            string duplicate = Convert.ToString(Console.ReadLine());    //宣告是否重複
            int[] list = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };  //設置數字的list
            
            // 根據條件產生數字
            string answer = "";                                 //宣告答案為空字串
            if (duplicate == "N" || duplicate == "n")           //如果不重複則產生不重複的數字
            {
                string[] list2 = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                for (int i = 0; i < type; i++)                  //設置臨時list2用以剔除重複的數字
                {
                    int ramNum = ram.Next(0, 10 - i - 1);       
                    answer = answer + list2[ramNum];                             //置入不重複的答案
                    list2 = list2.Where(val => val != list2[ramNum]).ToArray();  //.NET此版本沒有remove 參考 https://dotblogs.com.tw/marcus116/2011/07/10/31423 完全搞不懂原理但能用
                }
            }
            else if (duplicate == "Y" || duplicate == "y")       //如果能重複則直接產生數字
            {
                for (int i = 0; i < type; i++)
                {
                    int ramNum = ram.Next(0, 9);                                //隨機產生答案
                    answer = answer + list[ramNum];
                }
            }
            Console.WriteLine("產生一個{0}位數字串\n遊戲開始請輸入猜測的數字",type);

            //開始猜
            int count = 0;                              //設置猜的次數器
            bool bingo = false;                         //
            while (bingo != true)                       //猜中就結束                      
            {
                count = count + 1;                      //每執行一次 猜的次數器+1
                string userGuess = Console.ReadLine();  //取得用戶輸入的數字
                if (userGuess ==answer)                 //如果輸入的數字正確則跳出
                {
                    bingo = true;
                    break;
                }
                int A = 0, B = 0;                       //宣告幾A幾B，預設為0

                char[] AB1,AB2;                         //宣告幾AB1 AB2，作為字串比叫的用途
                AB1 = userGuess.ToCharArray();  
                AB2 = answer.ToCharArray();
                for (int i = 0; i < type; i++)          //比較兩個Array，如果在相同位置相同的話等於A 記一次
                {
                    if (AB1[i] == AB2[i])
                    {
                        A = A +1;
                        AB1[i] = 'x';                   //將比對過的元素替代調以避免重複
                    }
                }
                for (int i = 0; i < type; i++)          //比較兩個Array，如果在不位置相同的話等於B 記一次
                {
                    for (int j = 0; j < type; j++)
                    {
                        if (AB1[j] == AB2[i])
                        {
                            B = B + 1;
                            AB1[i] = 'x';
                        }
                    }
                }
                Console.WriteLine("{0}A{1}B", A, B);    //輸出幾A幾B
            }
            Console.WriteLine("遊戲結束，答案是{0}，您這次猜{1}位數共猜了{2}次。",answer,type,count);
            Console.Read();
        }
    }
}
