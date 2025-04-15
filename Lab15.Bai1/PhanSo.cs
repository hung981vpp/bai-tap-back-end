using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15App.Bai1
{
    class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        // Constructor
        public PhanSo(int tuSo = 0, int mauSo = 1)
        {
            if (mauSo == 0)
            {
                throw new ArgumentException("Mẫu số không thể bằng 0");
            }

            TuSo = tuSo;
            MauSo = mauSo;
        }

        // Phương thức nhập phân số
        public void Nhap()
        {
            Console.Write("Nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Nhập mẫu số: ");
                MauSo = int.Parse(Console.ReadLine());
                if (MauSo == 0)
                {
                    Console.WriteLine("Mẫu số phải khác 0. Vui lòng nhập lại.");
                }
            } while (MauSo == 0);
        }

        // Cộng hai phân số
        public static PhanSo operator +(PhanSo ps1, PhanSo ps2)
        {
            int mauSoChung = ps1.MauSo * ps2.MauSo;
            int tuSoMoi = ps1.TuSo * ps2.MauSo + ps2.TuSo * ps1.MauSo;
            return new PhanSo(tuSoMoi, mauSoChung);
        }

        // Phương thức cộng hai phân số
        public PhanSo Cong(PhanSo ps)
        {
            int mauSoChung = MauSo * ps.MauSo;
            int tuSoMoi = TuSo * ps.MauSo + ps.TuSo * MauSo;
            return new PhanSo(tuSoMoi, mauSoChung);
        }

        // Phương thức tính tổng danh sách phân số
        public static PhanSo TinhTong(List<PhanSo> danhSachPhanSo)
        {
            if (danhSachPhanSo.Count == 0)
            {
                return new PhanSo(0, 1);
            }

            PhanSo tong = new PhanSo(0, 1);
            foreach (var ps in danhSachPhanSo)
            {
                tong = tong + ps;
            }

            return tong;
        }

        // Ghi đè phương thức ToString
        public override string ToString()
        {
            if (TuSo == 0)
                return "0";
            else if (MauSo == 1)
                return TuSo.ToString();
            else
                return $"{TuSo}/{MauSo}";
        }
    }
}
