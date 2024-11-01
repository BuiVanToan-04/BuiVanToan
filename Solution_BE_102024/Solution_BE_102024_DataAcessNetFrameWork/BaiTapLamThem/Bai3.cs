using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_102024_DataAcessNetFrameWork.BaiTapLamThem
{
    internal class Bai3
    {
        //Bài 3: Viết chương trình C# để giải bài tập chuyển đổi độ C thành độ K và độ F trong C# 
        //Biết rằng : 1 K = 1 C + 273
        //1 F = C* 18/10 + 32

        static void Main()
        {
            double c = 18.8;

            double k = ChuyenDoiK(c);
            Console.WriteLine($"C chuyển đổi thành K: {k}");
            double f = ChuyenDoiF(c);
            Console.WriteLine($"C chuyển đổi thành F: {f}");
        }

        static double ChuyenDoiK(double c)
        {
            return c + 273;
        } 

        static double ChuyenDoiF(double c)
        {
            return c * 18.0 / 10.0 + 32;
        }
    }
}
