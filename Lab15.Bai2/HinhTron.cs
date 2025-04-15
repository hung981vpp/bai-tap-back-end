using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15.Bai2
{
    // Lớp HinhTron kế thừa từ Hinh
    public class HinhTron : Hinh
    {
        private double BanKinh;

        public HinhTron(double banKinh)
        {
            BanKinh = banKinh;
        }

        public override double TinhChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }

        public override double TinhDienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }

        public override string Ten()
        {
            return $"Hình tròn (r={BanKinh})";
        }
    }
}
