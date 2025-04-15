using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13App
{
     class TaiLieu
    {
        //khai báo thuộc tính
        protected string? maTL;
        protected string? tenNXB;
        protected int soBan;
        //phương thức khởi tạo mặc định
        public TaiLieu() { }
        //phương thức khởi tạo có tham số
        public TaiLieu(string maTL, string tenNXB, int soBan)
        {
            this.maTL = maTL;
            this.tenNXB = tenNXB;
            this.soBan = soBan;
        }
        //phương thức nhập thông tin tài liệu
        public virtual void Nhap()
        {
            try
            {
                Console.Write("+ Ma tai lieu: ");
                maTL = Console.ReadLine();
                Console.Write("+ Ten nha xuat ban: ");
                tenNXB = Console.ReadLine();
                Console.Write("+ So ban phat hanh: ");
                soBan = int.Parse(Console.ReadLine() ?? "0");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //phương thức xuất thông tin tài liệu
        public virtual void Xuat()
        {
            Console.WriteLine($"+ Ma tai lieu: {maTL}");
            Console.WriteLine($"+ Ten nha xuat ban: {tenNXB}");
            Console.WriteLine($"+ So ban phat hanh: {soBan}");
        }
    }
}
