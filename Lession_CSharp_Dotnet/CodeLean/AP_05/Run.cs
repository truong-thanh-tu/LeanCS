using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.CodeLean.AP_05
{
    public static class Run
    {
        public static void Test()
        {

        }
        static void bai1()
        {
          /*  for ([initializers]; [condition];[iterator]) {
                // code to repeat goes here 
             }*/
        }
        static void bai2()
        {
            //for Loop 
            for (int i = 0 ; i < 10; i++)
            {
                // Code to execute.
            }
            //Trong vi du nay: i = O ; lé khé’i Tao= i < 1 0 ; 151 diéu kién: vé i++ 151 trinh vbng lap.
        }
        static void bai3()
        {
            //foreach Loop
            string[] names = new string[10]; 
            // Process each name in the array. 
            foreach (string name in names) 
            {
                // Code to execute. 
            }
        }
        static void bai4()
        {
            //while Loop
            string response = "value";
            while (response != "Quit")
            {
                // Process the data.
                response = "value";
            }
        }
        static void bai5()
        {
            //do Loop
            string response = "value";
            do {
                // Process the data.
                response = "value";
            } while (response != "Quit");
        }
    }
}
