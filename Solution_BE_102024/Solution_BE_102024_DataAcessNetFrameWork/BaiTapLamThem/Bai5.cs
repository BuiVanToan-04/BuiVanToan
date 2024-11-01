using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_102024_DataAcessNetFrameWork.BaiTapLamThem
{
    internal class Bai5
    {
        //bai5: Viết chương trình C# liệt kê tất cả các số nguyên tố nhỏ hơn n.
        static void Main()
        {
            int n = 100;
            for (int i = 0; i < n; i++)
            {
                if (KTraSoNguyenTo(i) == 1)
                {
                    Console.Write(i + " ");
                } 
            }
        }

        static int KTraSoNguyenTo(int a)
        {
            if (a < 2)
            {
                return -1;
            }
            for (int i = 2; i < a; i ++)
            {
                if (a % i == 0 )
                {
                    return -1;
                }
            }
            return 1;
        }
    }
}
