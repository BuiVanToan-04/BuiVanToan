using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_102024_DataAcessNetFrameWork.Buoi8_Class_Abstract
{
    public class Bai1
    {
        #region Đề bài 
        /*
         * Bài tập 1: Quản lý hình học
         Viết chương trình quản lý hình học đơn
        giản bao gồm hình chữ nhật và hình tròn. Hãy sử dụng abstract class để biểu
        diễn các hình học này và tính toán diện tích và chu vi của từng hình.
         */
        #endregion
    }

    public abstract class HinhHoc
    {
        public abstract double DienTich();
        public abstract double ChuVi();
    }
    public class HinhChuNhat : HinhHoc
    {
        private double ChieuRong {  get; set; }
        private double ChieuDai { get; set; }
        public HinhChuNhat() { }

        public HinhChuNhat(double chieuRong, double chieuDai)
        {
            ChieuRong = chieuRong;
            ChieuDai = chieuDai;
        }

        public override double ChuVi()
        {
            return 2 * (ChieuDai + ChieuRong);
        }

        public override double DienTich()
        {
            return ChieuRong * ChieuDai;
        }
    }

    public class HinhTron : HinhHoc
    {
        private double BanKinh { get; }

        public HinhTron(double banKinh)
        {
            BanKinh = banKinh;
        }

        public override double DienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }

        public override double ChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }
    }
}
