using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.CodeLean.AP_17
{
    class EvenProgram
    {
        public delegate string MyDel(string str);

       
            event MyDel MyEvent;

            public EvenProgram()
            {
                this.MyEvent += new MyDel(this.WelcomeUser);
            }

            public string WelcomeUser(string username)
            {
                return "Welcome " + username;
            }

          public  static void display()
             {
                EvenProgram obj1 = new EvenProgram();
                string result = obj1.MyEvent("Tutorials Point");
                Console.WriteLine(result);
            }

        }
}
