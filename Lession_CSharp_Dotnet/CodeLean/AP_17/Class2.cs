using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.CodeLean.AP_17
{
    class Class2
    {
     
            static int num = 19; public static int AddNum(int p) { num += p; return num; }
            public static int MultNum(int q) { num *= q; return num; }
            public static int getNum() { return num; }
         public   static void Display()
            { //create delegate instances
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            nc = nc1;
            nc += nc2;
            //calling multicast 
            nc(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();  
        }
    }
   }

