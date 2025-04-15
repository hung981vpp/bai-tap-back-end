using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15.Bai2
{
    public class HinhChuNhat : Hinh
    {
        private double ChieuDai, ChieuRong;

        public HinhChuNhat(double chieuDai, double chieuRong)
        {
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
        }

        public override double TinhChuVi()
        {
            return 2 * (ChieuDai + ChieuRong);
        }

        public override double TinhDienTich()
        {
            return ChieuDai * ChieuRong;
        }

        public override string Ten()
        {
            return $"Hình chữ nhật (dài = {ChieuDai}, rộng = {ChieuRong})";
        }
    }
}
