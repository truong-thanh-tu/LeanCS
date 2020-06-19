using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Reseach.OOP
{
     abstract class Animal
    {
        /* public virtual void animalSound()
         {
             Console.WriteLine("The animal makes a sound");
         }*/
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
}
