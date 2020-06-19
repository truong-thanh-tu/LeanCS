using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Reseach.hinh
{
    class Hinh
    {
        public int chieuCao;
        public int chieuRong;

        public int DienTich()
        {
            return chieuCao * chieuRong;
        }
        public int ChuVi()
        {
            return 2 * (chieuCao + chieuRong);
        }
    }
}
