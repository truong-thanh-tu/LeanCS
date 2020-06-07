using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Book.Session_9
{
    class Run
    {
        public static void Test()
        {
            SalaryDetail.Display();
        }
        class SalaryDetail
        {
            private string _empName;
            public string EmployeeName
            {
                get
                {
                    return _empName;
                }
                set { _empName = value; }
            }
            public static void Display()
            {
                SalaryDetail objSal = new SalaryDetail();
                objSal.EmployeeName = "Patrick Johnson";
                Console.WriteLine("Employee Name: " + objSal.EmployeeName);
            }
        }
    }
}
