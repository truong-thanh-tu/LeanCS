using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Reseach.HomeWork
{
    class Run
    {
       public static void Display()
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region Bai1
            Person teacher = new Teacher("Dang Kim Thi","Ha Noi",40);
            Person student = new Student("Trương Thanh Tu", "Hue", 23);

            student.ToShool();
            student.ToString();
            teacher.ToShool();
               #endregion
        }
    }
}
