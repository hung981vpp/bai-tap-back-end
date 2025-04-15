using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13App
{
    class TapChi : TaiLieu
    {
        //khai báo các thuộc tính
        private int soPH;
        private int thangPH;
        //phương thức khởi tạo mặc định
        public TapChi() { }
        //phương thức khởi tạo có tham số
        public TapChi(string maTL, string tenNXB, int soBan, int soPH, 
            int thangPH) : base(maTL, tenNXB, soBan)
        {
            this.soPH = soPH;
            this.thangPH = thangPH;
        }
        //phương thức nhập thông tin sách
        public override void Nhap()
        {
            try
            {
                base.Nhap();
                Console.Write("+ So phat hanh: ");
                soPH = int.Parse(Console.ReadLine() ?? "0");
                Console.Write("+ Thang phat hanh: ");
                thangPH = int.Parse(Console.ReadLine() ?? "0");
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
            Console.WriteLine($"+ So phat hanh: {soPH}");
            Console.WriteLine($"+ Thang phat hanh: {thangPH}");
        }
    }
}
