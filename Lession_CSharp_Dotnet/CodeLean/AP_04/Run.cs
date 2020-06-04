using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.CodeLean.AP_04
{
    public static class Run
    {
        public static void Test()
        {
         //   bai1();
         //   bai2();
         //   bai3();
         //   bai4();
        }
        static void bai1()
        {
            //if statement 
            string response = "Yes"; 
            if (response == "Yes") {
                // statements that will execute if the value of the response variable is 
                // yes, will be placed here. 
            }
        }
        static void bai2()
        {
            //if else Statements 
            string response = "value";
            if (response == "connection_failed") 
            { 
                // Block of code executes if the value of the response variable is "connection_failed". 
            } else { 
                // Block of code executes if the value of the response variable is not "connection_failed".
            }
        }
        static void bai3()
        {
            //else if Statements
            string response ="value";
            if (response == "connection_failed") { 
                // Block of code executes if the value of the response variable is "connection_failed".
            } else if (response == "connection_error") { 
                // Block of code executes if the value of the response variable is "connection_error".
            } else { 
                // Block of code executes if the value of the response variable is neither above responses. 
            }
        }
        static void bai4() {
            //switch Statement
            string response= "value";
            switch (response)
            {
                case "connection_failed":
                    // Block of code executes if the value of response is "connection_failed".
                    break;
                case "connection_success":
                    // Block of code executes if the value of response is "connection_success".
                    break; case "connection_error":
                    // Block of code executes if the value of response is "connection_error".
                    break;
                default:
                    // Block executes if none of the above conditions are met.
                    break;
            }
        }
    }
}
