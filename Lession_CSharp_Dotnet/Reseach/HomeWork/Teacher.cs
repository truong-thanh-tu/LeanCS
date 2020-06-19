using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Reseach.HomeWork
{
   class Teacher : Person
    {
        public Teacher(string name, string adress, int age)
        {
            this.name = name;
            this.adress = adress;
            this.age = age;
        }
        public override void ToShool()
        {
            Console.WriteLine("Tôi  tới trường");
        }
        public   void toString()
        {
            Console.WriteLine(this.name + " " + this.age + " " + this.adress);
        }
    }
}
