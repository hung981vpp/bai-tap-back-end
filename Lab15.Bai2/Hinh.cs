using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15.Bai2
{
    // Lớp cơ sở Hinh với các phương thức ảo
    public abstract class Hinh
    {
        public abstract double TinhChuVi();
        public abstract double TinhDienTich();
        public abstract string Ten();
    }
}
