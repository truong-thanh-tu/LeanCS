using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Book.Session_8
{
    class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Go, go");
        }
        public virtual void ALive()
        {
            Console.WriteLine("Alive : true");
        }

        public override void Habitat()
        {
            Console.WriteLine("Home");
        }
    }

}
