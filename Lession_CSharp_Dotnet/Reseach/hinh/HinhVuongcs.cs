using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Reseach.hinh
{
    class HinhVuongcs:Hinh
    {
        public static void Display()
        {
            Hinh hinhVuong = new Hinh();
            hinhVuong.chieuCao = 4;
            hinhVuong.chieuRong = 4;
            Console.WriteLine("Dien tich: {0}; Chu vi {1}",hinhVuong.DienTich(),hinhVuong.ChuVi());
        }
    }
}
