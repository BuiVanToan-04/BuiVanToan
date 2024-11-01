using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_102024_DataAcessNetFrameWork.BaiTapLamThem
{
    internal class BaiMuoi
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            SoChu<int, string> mot = new SoChu<int, string>(1, "Số một");
            SoChu<int, string> b = new SoChu<int, string>(12, "Số mười hai");
            Console.WriteLine($"{mot.Key} => {mot.Value}");
            Console.WriteLine($"{b.Key} => {b.Value}");
        }
    }
    class SoChu<TKey , TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public SoChu(TKey a, TValue b) 
        {
            Key = a;
            Value = b;
        }
    }
}
