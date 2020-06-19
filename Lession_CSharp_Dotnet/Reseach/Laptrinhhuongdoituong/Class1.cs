using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Reseach.Laptrinhhuongdoituong
{
    class Class1
    {
        int x, y;
        public Class1()
        {

        }
        public Class1(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void  nhap()
        {
            Console.WriteLine("Nhap gia tri vao: ");
            this.x = Int32.Parse(Console.ReadLine());
            this.y = Int32.Parse(Console.ReadLine());
        }

        public void chuyen()
        {
            this.x = -this.x;
            this.y = -this.y;
        }
        public void divhuyen(int dx, int dy)
        {
            this.x = dx;
            this.y = dy;
        }
        public void hienthi()
        {
            Console.WriteLine(this.x);
            Console.WriteLine(this.y);
        }
    }
}
