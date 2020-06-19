using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Book.Session_16
{
    class Class1
    {
        public int Divide(int first, int second)
        {
            int resutl = 0;

            try
            {
                resutl = first / second;
            }
            catch (DataMisalignedException ex)
            {
                Console.WriteLine("Cannot divide by zero, please provide a non-zero value for your second value");
            };
            return resutl;
        }
    }
}
