using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_102024_DataAcessNetFrameWork.BaiTapLamThem
{
    internal class Bai9
    {
        //Bài 9: Cho một mảng số nguyên hãy thực hiện sắp xếp dãy tang và giảm dần

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = { 1, 7, 2, 5, 9, 0, 6, 11, 46, 10, 3 };
            SapXepTangDan(arr);
        }
        static void SapXepTangDan(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Mảng sau khi sắp xếp tăng dần: " + string.Join(", ", arr));

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Mảng sau khi sắp xếp giảm dần: " + string.Join(", ", arr));
        }
    }
}
