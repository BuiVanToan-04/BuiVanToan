using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_102024_DataAcessNetFrameWork.BaiTapLamThem
{
    internal class Bai7
    {
        //Bài 7: Kiểm tra 1 số có phải số nguyen tố không ?
        static void Main()
        {
            Console.WriteLine("nhập a: ");
            int a = int.Parse(Console.ReadLine());

            var b = KTraSoNguyenTo(a);
            if (b == 1)
            {
                Console.WriteLine("Số nguyên số");
            }
            else Console.WriteLine("Khong phai so nguyen to");
        }
        static int KTraSoNguyenTo(int a)
        {
            if (a < 2)
            {
                return -1;
            }
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return -1;
                }
            }
            return 1;
        }
    }
}
