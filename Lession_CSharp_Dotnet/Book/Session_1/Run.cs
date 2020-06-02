using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Book.Session_1
{
     public static class Run
    {
       public static void Test()
        {
            bai1();
            Console.ReadKey();
        }
        static void bai1()
        {
            bool boolTest = true;
            short betyTest = 19;
            int intTest = 2;
            float floatTest = 14.5f;
            Console.WriteLine("boolTest = {0}", boolTest);
            Console.WriteLine("betyTest = {0}", betyTest);
            Console.WriteLine("intTest = {0}", intTest);
            Console.WriteLine("floatTest = {0}", floatTest);
        }
        static void bai2()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Trương Thanh Tú");
            Console.ReadKey();
        }
        static void bai3()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int number;
            string name;
            number = 4;
            name = "Thanh Tú";
            Console.WriteLine("Ban: {0} đã hoàn thành {1} khóa học của trường ", name, number);
            Console.ReadKey();
        }
        static void bai4()
        {
            string userName;
            int age;
            double salary;
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Name: {0}, Age: {1} , Salary: {2}", userName, age, salary);
            Console.ReadKey();
        }
    }

}
