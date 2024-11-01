using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_102024_DataAcessNetFrameWork.BaiTapLamThem
{
    internal class Bai10
    {
        //Bài 4: Tính giai thừa của 1 số
        //
        static void Main()
        {
            int n = 6;
            var b = TinhGiaThua<int>(n);
            Console.WriteLine(b);
        }

        static T TinhGiaThua<T>(T n)
        {
            dynamic a = n;
            if (a <= 1 )
            {
                return a = 1;
            }
            return a * TinhGiaThua(a - 1);
        }
    }
}
