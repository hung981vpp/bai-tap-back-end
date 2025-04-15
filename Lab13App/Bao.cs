using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13App
{
    class Bao : TaiLieu
    {
        //khai báo các thuộc tính
        private string? ngayPH;
        //phương thức khởi tạo mặc định
        public Bao() { }
        //phương thức khởi tạo có tham số
        public Bao(string maTL, string tenNXB, int soBan, 
            string ngayPH) : base(maTL, tenNXB, soBan)
        {
            this.ngayPH = ngayPH;
        }
        //phương thức nhập thông tin sách
        public override void Nhap()
        {
            try
            {
                base.Nhap();
                Console.Write("+ Ngay phat hanh: ");
                ngayPH = Console.ReadLine();
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
            Console.WriteLine($"+ Ngay phat hanh: {ngayPH}");
        }
    }
}
