using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace 台電電價計算
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("台電電價計算");
            Console.WriteLine("請輸入月份");
            int _用電月份 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("請輸入用電度數");
            int _用電度數 = Convert.ToInt16(Console.ReadLine());
            int _夏制 = 1;
            double[,] _電價 = new double[2, 7] { { 0, 1.63, 2.10, 2.89, 3.94, 4.60, 5.03 }, { 0, 1.63, 2.38, 3.52, 4.80, 5.66, 6.41 } };
            double[] _度數分段 = new double[7] { 0, 120, 330, 500, 700, 1000, _用電度數 };
            int _分段 = 0;
            double _總電費 = 0;
            if (_用電月份<6|| _用電月份>9){_夏制 = 0;}
            for (int i = 0; i < 6; i++){if (_用電度數 > _度數分段[i]){_分段 = i;}}
            switch (_分段)
            {
                case 1:
                    _總電費=(_用電度數 - 120) * _電價[_夏制, 2] + 120 * _電價[_夏制, 1];                                      
                    break;
                case 2:
                    _總電費 = (_用電度數 - 330) * _電價[_夏制, 3] + 120 * _電價[_夏制, 1] + 210 * _電價[_夏制, 2];
                    break;
                case 3:
                    _總電費 = (_用電度數 - 500) * _電價[_夏制, 4] + 120 * _電價[_夏制, 1] + 210 * _電價[_夏制, 2] + 170 * _電價[_夏制, 3];
                    break;
                case 4:
                    _總電費 = (_用電度數 - 700) * _電價[_夏制, 5] + 120 * _電價[_夏制, 1] + 210 * _電價[_夏制, 2] + 170 * _電價[_夏制, 3] + 200 * _電價[_夏制, 4];
                    break;
                case 5:
                    _總電費 = (_用電度數 - 1000) * _電價[_夏制, 6] + 120 * _電價[_夏制, 1] + 210 * _電價[_夏制, 2] + 170 * _電價[_夏制, 3] + 200 * _電價[_夏制, 4] + 300 * _電價[_夏制, 5];
                    break;
                default:
                    _總電費 = _用電度數 * _電價[_夏制, 1];
                    break;
            }
            Console.WriteLine("{0}月份的電費是{1}元", _用電月份, _總電費);
            /*                                  //      殘念 以下算法出現問題
            for (int i = 5; i > 0; i--)
            {
                if (_用電度數> _度數分段[i-1])
                {
                    Console.WriteLine("用電度數1　{0}",i);
                    _總電價 = _總電價 + _電價[_夏制, i] * (_用電度數 - _度數分段[i]);
                    Console.WriteLine(_總電價);
                    break;
                }
                else
                {
                    Console.WriteLine("用電度數2　{0}", i);
                    if (((_用電度數 - _度數分段[i-1]) * _電價[_夏制, i])>0)
                    {
                        _總電價 = _總電價 + (_用電度數 - _度數分段[i-1]) * _電價[_夏制, i];
                    } 
                }
            }
            for (int i = 1; i <6 ; i++)
            {
                if (_用電度數>= _度數分段[i])
                {
                    _總電價 = _總電價 + (_度數分段[i] - _度數分段[i - 1]) * _電價[_夏制, i];
                }
            }*/
            /*
            for (int i = 6; i > 1; i--)
            {
                if (_用電度數 > _度數分段[i-1])
                {
                    _總電價 = _總電價 - _度數分段[i] - _度數分段[i - 1];
                    Console.WriteLine("總電價2" + _總電價);
                    break;
                }
            }
            Console.WriteLine("總電價3" + _總電價);
            */
 /*           
            Console.ReadLine();
*/
            
        }
    }
}
