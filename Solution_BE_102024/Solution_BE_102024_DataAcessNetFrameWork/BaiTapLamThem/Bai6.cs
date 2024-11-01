using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_102024_DataAcessNetFrameWork.BaiTapLamThem
{
    internal class Bai6
    {
        //Kiểm tra một số là số chẵn hay số lẻ trong C#
        static void Main()
        {
            Console.WriteLine("Nhập a: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0) 
            {
                Console.WriteLine("Chẵn");
            }
            else Console.WriteLine("lẻ");
        }
    }
}
