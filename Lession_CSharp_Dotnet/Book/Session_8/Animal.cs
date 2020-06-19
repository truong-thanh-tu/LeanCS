using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Book.Session_8
{
    public abstract class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Every animal eats food in order to survive");
        }
        public abstract void AnimalSound();
        public abstract void Habitat();
       /* public abstract void Alive();*/
    }
}
