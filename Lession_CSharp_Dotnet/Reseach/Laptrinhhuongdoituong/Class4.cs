using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Reseach.Laptrinhhuongdoituong
{
    public class Class4

    {
      public  int num1;
      public  int num2;
      public  int num3;
      public  float deta;
        public Class4(int num1, int num2, int num3){
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
         }
        public void GiaiPhuongTrinh()
        {
           if( num1 == 0)
            {
                if(num2 != 0)
                {
                    Console.WriteLine("Phuong trinh co mot nghiem: {0}",(float)(-num2/num1));
                }
                else
                {
                    if(num3 != 0)
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    }
                }
            }
            else
            {
                deta = num2 * num2 - 4 * num1 * num3;
                if(deta > 0)
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet: ");
                    Console.WriteLine("Nghiem 1 : {0}", (float)((-num2 + Math.Sqrt(deta)) / 2 * num1));
                    Console.WriteLine("Nghiem 2 : {0}", (float)((-num2 - Math.Sqrt(deta)) / 2 * num1));
                }
                else if( deta == 0)
                {
                    Console.WriteLine("Phuong trinh co 1 nghiem phan biet: ");
                    Console.WriteLine("nghiem  : {0}",(float)(-num2 / 2*num1));
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
        }
    }
}
