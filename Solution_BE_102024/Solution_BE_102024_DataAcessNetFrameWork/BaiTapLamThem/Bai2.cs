using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Solution_BE_102024_DataAcessNetFrameWork.BaiTapLamThem
{
    internal class Bai2
    {
        //Bài 2: Viết Chương trình giải phương trình bậc 1 , bậc 2 ( 2x2 + 3x +1=0)
        static void Main()
        {
            int a = 3, b = 27, d = 4;
            GiaiPhuongTrinhBac2<int>(a, b, d);
            Console.WriteLine("============================");
            double g = 18.7, h = 3.6;
            GiaiPhuongTrinhBac1<double>(g, h);
        }

        static void GiaiPhuongTrinhBac2<T>(T a, T b, T c)
        {
            dynamic aData = a;
            dynamic bData = b;
            dynamic cData = c;

            if (aData == 0)
            {
                Console.WriteLine("Day laa pt b1");
                GiaiPhuongTrinhBac1(bData, cData);
            }
            var delta = bData * bData - 4 * aData * cData;

            if (delta > 0)
            {
                var x1 = (-bData + Math.Sqrt(delta)) / (2 * aData);
                var x2 = (-bData - Math.Sqrt(delta)) / (2 * aData);
                Console.WriteLine($"X1: {x1}, X2: {x2}");
            }
            else if (delta == 0)
            {
                var x = -bData / 2 * aData;
                Console.WriteLine($"X: {x}");
            }
            else
            {
                Console.WriteLine("Voo nghiem");
            }
        }

        private static void GiaiPhuongTrinhBac1<T>(T a, T b)
        {
            dynamic aData = a;
            dynamic bData = b;

            if (aData == 0)
            {
                Console.WriteLine("Vo so nghiem");
            }
            var x = -bData / aData;
            Console.WriteLine($"X: {x}");
        }
    }
}
