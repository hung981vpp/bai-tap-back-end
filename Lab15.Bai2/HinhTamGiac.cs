using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15.Bai2
{
    public class HinhTamGiac : Hinh
    {
        private double CanhA, CanhB, CanhC;

        public HinhTamGiac(double canhA, double canhB, double canhC)
        {
            // Kiểm tra tính hợp lệ của tam giác
            if (canhA + canhB <= canhC || canhA + canhC <= canhB || canhB + canhC <= canhA)
            {
                throw new ArgumentException("Ba cạnh không tạo thành tam giác hợp lệ");
            }

            CanhA = canhA;
            CanhB = canhB;
            CanhC = canhC;
        }

        public override double TinhChuVi()
        {
            return CanhA + CanhB + CanhC;
        }

        public override double TinhDienTich()
        {
            // Sử dụng công thức Heron để tính diện tích
            double p = TinhChuVi() / 2;
            return Math.Sqrt(p * (p - CanhA) * (p - CanhB) * (p - CanhC));
        }

        public override string Ten()
        {
            return $"Hình tam giác (a = {CanhA}, b = {CanhB}, c = {CanhC})";
        }
    }

}
