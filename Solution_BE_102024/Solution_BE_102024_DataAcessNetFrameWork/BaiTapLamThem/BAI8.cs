using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_102024_DataAcessNetFrameWork.BaiTapLamThem
{
    internal class BAI8
    {
        //Bài 8: Cho một mảng số nguyên hãy in ra mảng sổ lẻ và mảng số chẵn
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }; 
            ShowArr(arr);
        }

        static void ShowArr(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Mảng rỗng");
            }
            Console.WriteLine("Phần tử chẵn");
            for (int i = 0; i < arr.Length; i++) 
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Phần tử lẻ");
            for (int j = 0; j < arr.Length; j++)
            {
                if (j % 2 == 1)
                {
                    Console.Write(j + " ");
                }
            }
        }
    }
}
