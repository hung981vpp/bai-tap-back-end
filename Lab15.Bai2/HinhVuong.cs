using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15.Bai2
{
    public class HinhVuong : Hinh
    {
        private double Canh;

        public HinhVuong(double canh)
        {
            Canh = canh;
        }

        public override double TinhChuVi()
        {
            return 4 * Canh;
        }

        public override double TinhDienTich()
        {
            return Canh * Canh;
        }

        public override string Ten()
        {
            return $"Hình vuông (a={Canh})";
        }
    }
}
