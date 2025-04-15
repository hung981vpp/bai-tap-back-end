using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13App
{
    class QuanLyTaiLieu
    {
        private int soLuong; //số lượng tài liệu
        private TaiLieu[] taiLieus = new TaiLieu[100];

        // Phương thức thêm tài liệu
        public void ThemTaiLieu(TaiLieu tl)
        {
            if (soLuong < taiLieus.Length)
            {
                taiLieus[soLuong] = tl;
                soLuong++;
                Console.WriteLine("Thêm tài liệu thành công!");
            }
            else
            {
                Console.WriteLine("Danh sách tài liệu đã đầy!");
            }
        }

        // Phương thức nhập thông tin tài liệu
        public void NhapThongTin()
        {
            Console.WriteLine("\n===== NHẬP THÔNG TIN TÀI LIỆU =====");
            Console.WriteLine("1. Sách");
            Console.WriteLine("2. Tạp chí");
            Console.WriteLine("3. Báo");
            Console.Write("Chọn loại tài liệu (1-3): ");

            int luaChon = int.Parse(Console.ReadLine() ?? "0");

            try
            {
                TaiLieu taiLieu;

                if (luaChon == 1)
                {
                    taiLieu = new Sach();
                    Console.WriteLine("\nNhập thông tin sách:");
                }
                else if (luaChon == 2)
                {
                    taiLieu = new TapChi();
                    Console.WriteLine("\nNhập thông tin tạp chí:");
                }
                else if (luaChon == 3)
                {
                    taiLieu = new Bao();
                    Console.WriteLine("\nNhập thông tin báo:");
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    return;
                }

                taiLieu.Nhap();
                ThemTaiLieu(taiLieu);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }

        // Phương thức hiển thị tất cả tài liệu
        public void HienThiTatCa()
        {
            if (soLuong == 0)
            {
                Console.WriteLine("\nDanh sách tài liệu trống!");
                return;
            }

            Console.WriteLine("\n===== DANH SÁCH TÀI LIỆU =====");
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"\nTài liệu {i + 1}:");

                if (taiLieus[i] is Sach)
                    Console.WriteLine("Loại tài liệu: Sách");
                else if (taiLieus[i] is TapChi)
                    Console.WriteLine("Loại tài liệu: Tạp chí");
                else if (taiLieus[i] is Bao)
                    Console.WriteLine("Loại tài liệu: Báo");

                taiLieus[i].Xuat();
                Console.WriteLine("-----------------------------");
            }
        }

        // Phương thức tìm kiếm tài liệu theo loại
        public void TimKiemTheoLoai()
        {
            if (soLuong == 0)
            {
                Console.WriteLine("\nDanh sách tài liệu trống!");
                return;
            }

            Console.WriteLine("\n===== TÌM KIẾM TÀI LIỆU THEO LOẠI =====");
            Console.WriteLine("1. Sách");
            Console.WriteLine("2. Tạp chí");
            Console.WriteLine("3. Báo");
            Console.Write("Chọn loại tài liệu muốn tìm (1-3): ");

            int luaChon = int.Parse(Console.ReadLine() ?? "0");
            bool timThay = false;

            Console.WriteLine("\nKết quả tìm kiếm:");
            for (int i = 0; i < soLuong; i++)
            {
                if ((luaChon == 1 && taiLieus[i] is Sach) ||
                    (luaChon == 2 && taiLieus[i] is TapChi) ||
                    (luaChon == 3 && taiLieus[i] is Bao))
                {
                    Console.WriteLine($"\nTài liệu {i + 1}:");
                    taiLieus[i].Xuat();
                    Console.WriteLine("-----------------------------");
                    timThay = true;
                }
            }

            if (!timThay)
            {
                Console.WriteLine("Không tìm thấy tài liệu theo loại đã chọn!");
            }
        }

        // Phương thức menu chính
        public void Menu()
        {
            int luaChon;
            do
            {
                Console.WriteLine("\n===== QUẢN LÝ TÀI LIỆU =====");
                Console.WriteLine("1. Nhập thông tin tài liệu");
                Console.WriteLine("2. Hiển thị thông tin tất cả tài liệu");
                Console.WriteLine("3. Tìm kiếm tài liệu theo loại");
                Console.WriteLine("4. Thoát");
                Console.Write("Nhập lựa chọn của bạn: ");

                luaChon = int.Parse(Console.ReadLine() ?? "0");

                switch (luaChon)
                {
                    case 1:
                        NhapThongTin();
                        break;
                    case 2:
                        HienThiTatCa();
                        break;
                    case 3:
                        TimKiemTheoLoai();
                        break;
                    case 4:
                        Console.WriteLine("Cảm ơn đã sử dụng chương trình!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

            } while (luaChon != 4);
        }
    }
}