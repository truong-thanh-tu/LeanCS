using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Reseach.OOP
{
  public   class Run
    {
        public static void Display()
        {
            #region car
            /*  Car myObj = new Car();
              Car myObje1 = new Car();
              Console.WriteLine(myObj.color);
              Console.WriteLine(myObje1.color);*/

            /* Car myObj = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);*/

            /* Car Ford = new Car();
             Ford.model = "Mustang";
             Ford.color = "red";
             Ford.year = 1986;

             Car Opel = new Car();
             Opel.model = "Astra";
             Opel.color = "While";
             Opel.year = 2005;

             Console.WriteLine(Ford.model);
             Console.WriteLine(Opel.model);*/
            /*  Car myObj = new Car("Astra", "While", 2005);
              Console.WriteLine(myObj.model + " " + myObj.color + " " + myObj.year);*/

            /* Car myObj = new Car();
             myObj.honk();
             Console.WriteLine(myObj.brank + " "+myObj.modelName);*/
            #endregion
            #region program
            /* Personcs myObj = new Personcs();
             myObj.Name = "Thanh Tu";
             Console.WriteLine(myObj.Name);*/

            /* Animal myAnimal = new Animal();*/
            //   Animal myPig = new Pig();
            /* Animal myDog = new Dog();*/

            /* myAnimal.animalSound();*/
            /*  myDog.animalSound();*/
            /*myPig.animalSound();
            myPig.sleep();*/
            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();
            #endregion
        }
    }
}
