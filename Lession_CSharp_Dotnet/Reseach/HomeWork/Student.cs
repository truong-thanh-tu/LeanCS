using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Reseach.HomeWork
{
    class Student:Person
    {
        public Student(string name, string adress, int age)
        {
            this.name = name;
            this.adress = adress;
            this.age = age;
        }
        public override void ToShool()
        {
            Console.WriteLine("Tôi không tới trường");
        }
        public void Tostring()
        {
            Console.WriteLine(this.name + " " + this.age + " " + this.adress);
        }
    }
}
