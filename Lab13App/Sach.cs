using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13App
{
    class Sach : TaiLieu
    {
        //khai báo các thuộc tính
        private string? tenTG;
        private int soTrang;
        //phương thức khởi tạo mặc định
        public Sach() { }
        //phương thức khởi tạo có tham số
        public Sach(string maTL, string tenNXB, int soBan, string tenTG,
            int soTrang) : base(maTL, tenNXB, soBan)
        {
            this.tenTG = tenTG;
            this.soTrang = soTrang;
        }
        //phương thức nhập thông tin sách
        public override void Nhap()
        {
            try
            {
                base.Nhap();
                Console.Write("+ Ten tac gia: ");
                tenTG = Console.ReadLine();
                Console.Write("+ So trang: " );
                soTrang = int.Parse(Console.ReadLine() ?? "0");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //phương thức xuất thông tin sách
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"+ Ten tac gia: {tenTG}");
            Console.WriteLine($"+ So trang: {soTrang}");
        }
    }
}
