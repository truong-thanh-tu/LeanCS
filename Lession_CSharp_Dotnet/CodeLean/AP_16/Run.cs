using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Book.Session_16
{
    class Run
    {
       public static void Display()
        {
            int first = 9;
            int second = 10;
            Class1 cl = new Class1();
            int result;
            Console.WriteLine("Enter your first number: ");
            first = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            second = System.Int32.Parse(Console.ReadLine());
            result = cl.Divide(first, second);
            Console.WriteLine("Result: {0}",result);
        }
    }
}
