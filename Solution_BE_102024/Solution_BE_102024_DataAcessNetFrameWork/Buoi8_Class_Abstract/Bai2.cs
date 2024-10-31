using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_102024_DataAcessNetFrameWork.Buoi8_Class_Abstract
{
    public abstract class Bai2
    {
        public abstract double TinhLuong();
    }

    public class NhanVienFullTime : Bai2
    {
        public string FullName { get; set; }
        private int NgayLam {  get; set; }
        private float PhanTramThuong { get; set; }
        private double LuongCoBan {  get; set; }
        private double ThucLinh { get; set; }

        public NhanVienFullTime() { }

        public NhanVienFullTime(string fullName,int ngayLam, float phanTramThuong, double luongCoBan)
        {
            FullName = fullName;
            NgayLam = ngayLam;
            PhanTramThuong = phanTramThuong;
            LuongCoBan = luongCoBan;
            ThucLinh = TinhLuong();
        }

        public override double TinhLuong()
        {
            var thuong = (NgayLam > 20) ? 0.2f * LuongCoBan : 0;
            return NgayLam * LuongCoBan + thuong;
        }

        public override string ToString() => $"Nhân viên: {FullName}, " +
            $"Ngày làm: {NgayLam}, Phần trăm thưởng: {PhanTramThuong}, Lương cơ bản: {LuongCoBan}, Thực Linh: {TinhLuong()}";
        
    }

    public class NhanVienPartTime : Bai2
    {
        public string FullName { get; set; }
        private int NgayLam { set; get; }
        private double MucLuong { get; set; }
        public NhanVienPartTime() { }

        public NhanVienPartTime(string fullName,int ngayLam, double mucLuong)
        {
            FullName = fullName;
            NgayLam = ngayLam;
            MucLuong = mucLuong;
        }

        public override double TinhLuong() => NgayLam * MucLuong;
        
        public override string ToString() => $"Nhân viên: {FullName}, " +
                            $"Ngày làm: {NgayLam}, Thực Linh: {TinhLuong()}";
    }
}
