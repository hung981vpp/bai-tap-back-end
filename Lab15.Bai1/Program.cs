using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15App.Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<PhanSo> danhSachPhanSo = new List<PhanSo>();

            Console.Write("Nhập số lượng phân số: ");
            int n = int.Parse(Console.ReadLine());

            // Nhập các phân số
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập phân số thứ {i + 1}:");
                PhanSo ps = new PhanSo();
                ps.Nhap();
                danhSachPhanSo.Add(ps);
            }

            // Hiển thị danh sách phân số
            Console.WriteLine("\nDanh sách phân số:");
            for (int i = 0; i < danhSachPhanSo.Count; i++)
            {
                Console.WriteLine($"Phân số {i + 1}: {danhSachPhanSo[i]}");
            }

            // Tính và hiển thị tổng
            PhanSo tong = PhanSo.TinhTong(danhSachPhanSo);
            Console.WriteLine($"\nTổng các phân số là: {tong}");

            Console.ReadKey();
        }
    }
}
