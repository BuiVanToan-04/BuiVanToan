using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_102024_DataAcessNetFrameWork.BaiTapLamThem
{
    internal class Bai1
    {
        //Bài 1: Viết chương trình C# để giải bài tập tìm tổng hai số , tích 2 số , hiệu 2 số
        static T PhepCong<T>(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }
        static T PhepTru<T>(T a, T b)
        {
            return (dynamic)a - (dynamic)b;
        }

        static T PhepNhan<T>(T a, T b)
        {
            return (dynamic)a * (dynamic)b;
        }

        static void Main()
        {
            int a = 5, b = 8;
            var c = PhepCong<int>(a, b);
            Console.WriteLine(c);

            var d = PhepNhan<int>(a, b);
            Console.WriteLine(d);

            var e = PhepTru<int>(a, b);
            Console.WriteLine(e);
        }
    }
}
