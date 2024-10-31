using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_102024_DataAcessNetFrameWork.Buoi8_Class_Abstract
{
    public abstract class Bai3
    {
        public string Name { get; set; }
        public double GiaBanDau { get; set; }

        public Bai3() { }
        public Bai3(string name, double giaBanDau)
        {
            Name = name;
            GiaBanDau = giaBanDau;
        }

        public abstract double TinhGIa();
        public override string ToString() => $"Tên sản phẩm: {Name}, Gía ban đầu: {GiaBanDau}";
    }
    public class Phone : Bai3
    {
        public double GiamGia { get; set; }

        public Phone() : base() { }

        public Phone(string name, double gia, double giamGia) : base(name, gia)
        {
            GiamGia = giamGia;
        }

        public override double TinhGIa() => GiaBanDau - GiamGia;
        
        public override string ToString() => base.ToString() + $"Giam gia: {GiamGia}, Gia ban: {TinhGIa()}";
    }

    public class LapTop : Bai3
    {
        public float KhuyenMai { get; set; }

        public LapTop() : base() { }
        public LapTop(string name, double gia, float khuyenMai) : base(name, gia)
        {
            KhuyenMai = khuyenMai;
        }

        public override double TinhGIa() => GiaBanDau * KhuyenMai;

        public override string ToString() => base.ToString() + $"Khuyến mãi: {KhuyenMai}, Gía bán: {TinhGIa()}";
        
    }
}
