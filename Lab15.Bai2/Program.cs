using System.Text;
using Lab15.Bai2;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        try
        {
            // Tạo danh sách các hình
            List<Hinh> danhSachHinh = new List<Hinh>
            {
                new HinhTron(5),
                new HinhVuong(4),
                new HinhTamGiac(3, 4, 5),
                new HinhChuNhat(6, 8)
            };

            // Tính tổng chu vi và diện tích
            double tongChuVi = 0;
            double tongDienTich = 0;

            Console.WriteLine("Thông tin các hình:");
            Console.WriteLine("-------------------------------------");

            foreach (var hinh in danhSachHinh)
            {
                double chuVi = hinh.TinhChuVi();
                double dienTich = hinh.TinhDienTich();

                tongChuVi += chuVi;
                tongDienTich += dienTich;

                Console.WriteLine($"{hinh.Ten()}:");
                Console.WriteLine($"- Chu vi: {chuVi:F2}");
                Console.WriteLine($"- Diện tích: {dienTich:F2}");
                Console.WriteLine("-------------------------------------");
            }

            Console.WriteLine($"Tổng chu vi: {tongChuVi:F2}");
            Console.WriteLine($"Tổng diện tích: {tongDienTich:F2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi: {ex.Message}");
        }
    }
}