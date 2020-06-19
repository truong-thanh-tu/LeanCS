using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Reseach.HomeWork
{
    class Person
    {
        public string name;
        public int age;
        public string adress;

        public virtual void ToShool() {
            Console.WriteLine("Tôi không tới trường");
        }
        public virtual void Tostring()
        {
            Console.WriteLine(this.name + " " + this.age + " " + this.adress);
        }
    }
}
