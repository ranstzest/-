using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 分水解謎
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupWater= {0, 0, 0 } ; /*初始水量*/
            int[] cupFull = {7,10,5 } ;/*杯子容量(7/10/5是經典題目)*/
            int answer = 6;/*答案要求水量*/
            bool right = false;
            Console.WriteLine("----------------倒水解謎--------------");
            Console.WriteLine("\t輸入說明：");
            Console.WriteLine("\t[1]、[2]、[3]：杯子編號左至右");
            Console.WriteLine("\t[1]，[1]水杯有水清空，沒水裝滿");
            Console.WriteLine("\t[1][2]將左邊的水杯倒向右邊\n");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\t請在任一杯子裝入6的水量");
            Console.WriteLine("\t杯[1]\t杯[2]\t杯[3]");
            Console.WriteLine("-----------當前水量/水杯容量----------\n\n\n");
            
            while (right == false)
            {   
                Console.SetCursorPosition(0, Console.CursorTop-3);
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("\t{0}/{1}", cupWater[i], cupFull[i]);             
                }   
                Console.WriteLine("\n\t\t\t  \tnext");
                string input = Console.ReadLine();
                if (input.Length>1)
                {
                    
                    int A = Convert.ToInt32(input.Substring(0, 1))-1;
                    int B = Convert.ToInt32(input.Substring(1, 1))-1;
                    int i, j;
                    if (cupWater[A]+ cupWater[B] <= cupFull[B]) 
                    {
                        cupWater[B] = cupWater[A] + cupWater[B];
                        cupWater[A] = 0;
                    }
                    else if (cupWater[A] + cupWater[B]> cupFull[B])/*7/7 5/10*/
                    {
                        i = cupWater[A] - (cupFull[B] - cupWater[B]);
                        cupWater[B] = cupWater[A]+cupWater[B]-i;
                        cupWater[A] =i;                       
                    }
                }
                else
                {
                    if (cupWater[Convert.ToInt32(input) - 1]>0)
                    {/*有水倒掉*/
                        cupWater[Convert.ToInt32(input) - 1] = 0;
                    }
                    else
                    {/*沒水裝滿*/
                        cupWater[Convert.ToInt32(input) - 1] = cupFull[Convert.ToInt32(input) - 1];
                    }
                }

                for (int j = 0; j < 3; j++)
                {
                    if (cupWater[j]==answer)
                    {
                        Console.Write("\t{0}/{1}", cupWater[j], cupFull[j]);
                        Console.WriteLine("完成達成");
                        right = true;
                    }
                    //break;
                }
            }
            Console.ReadLine();
        }
    }
}
