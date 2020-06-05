using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Book.Session_8
{
     public static class Run
    {
        public static void Test()
        {

        }
        abstract class BaseClass
        {
            public abstract void MethodA();
            public static void MethodB()
            {
                Console.WriteLine("This is the non abstract method");
            }
        }
        class DerivedClass: BaseClass
        {
            public override void MethodA()
            {
                Console.WriteLine("This is the non adstract methodA inner");
            }
        }
       
        public static void Display()
        {
            DerivedClass DC = new DerivedClass();
            DerivedClass.MethodB();

            DC.MethodA();
           
           



        }

       
    }
}
