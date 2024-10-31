using Solution_BE_102024_DataAcessNetFrameWork.Buoi8_Class_Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_102024_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Buổi 8: Class-Abstract
            //Bài 1
            HinhChuNhat hcn = new HinhChuNhat(4, 5);
            Console.WriteLine($"Diện tích hình chữ nhật: {hcn.DienTich()}");
            Console.WriteLine($"Chu vi hình chữ nhật: {hcn.ChuVi()}");

            HinhTron ht = new HinhTron(5);
            Console.WriteLine($"Diện tích hình tròn: {ht.DienTich()}");
            Console.WriteLine($"Chu vi hình tròn: {ht.ChuVi()}");
            Console.WriteLine("-----------------------------------------------------------" +
                "--------------------------------------------------------");

            //Bài 2
            NhanVienFullTime nvF = new NhanVienFullTime("Nguyen van A", 23, 0.2f, 300000);
            Console.WriteLine(nvF);

            NhanVienPartTime nvP = new NhanVienPartTime("Nguyen van B", 20, 250000);
            Console.WriteLine(nvP);
            Console.WriteLine("-----------------------------------------------------------" +
                "--------------------------------------------------------");

            //Bài 3
            Bai3 b3 = new Phone("San Pham A", 500000,25000);
            Console.WriteLine(b3);

            Bai3 bai3 = new LapTop("San pham b", 1000000, 0.5f);
            Console.WriteLine(bai3);

        }
    }
}
