using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Reseach.OOP
{
    class Dog:Animal 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog say: bow wow");
        }
    }
}
