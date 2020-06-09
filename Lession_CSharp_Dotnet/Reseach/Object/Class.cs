using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Reseach.Object
{
    //The Point class is derived from System.Object
   public static class Class
    {
        public static void Run()
        {
            //   Car.Runs();
            //   MyClass.fullThrottle();
            //   MyCar.yourCar();
            //   CarOne.display();
            //   ObjectCar.ObjectCarDisplay();
            //   ObjectMyCar.display();
            //   Program.display();
            //   ProgramSecond.display();
            ProgramThree.display();
        }

        // Class Car
        public class Car
        {   
            //Thuộc tính của Car
            String color = "red";
            String color1 = "black";

            //Phương thức Car hiển thị 
           public  static void Runs()
            {
                //Khởi tạo đối tượng myCar
                Car myObj = new Car();
                Car myObj1 = new Car();
                //Hiển thị ra nôi dung 
                Console.WriteLine(myObj.color);
                Console.WriteLine(myObj1.color1);
            }


        }
       
        // Class MyClass 
        public class MyClass
        {
            String color = "Red"; // field
            int maxSpeed = 200; // field

            public static void fullThrottle() // method
            {
                Console.WriteLine("The car is going as fast as it can!");
            }

        }
      
        // Class MyCar 
        public class MyCar
        {
           static String color = "Black";
           static String name = "ANC";
           static int maxSpeed = 20;

            public  static void yourCar()
            {
                Console.WriteLine("name : {0}; maxSpeed : {1}; color : {2} ",MyCar.name,MyCar.maxSpeed,MyCar.color);
            }
        }

        // Class CarOne
        public class CarOne
        {
            String model;
            string color;
            int year;

            public static void display()
            {
                CarOne Ford = new CarOne();
                Ford.model = "Mustang";
                Ford.color = "red";
                Ford.year = 1998;

                Console.WriteLine("Mode  : {0};" +
                                  "Color : {1};" +
                                  "Year  : {2};",Ford.model,Ford.color,Ford.year);
            }
        }

        // Object 
        public class ObjectCar
        {
            string color;                 // field
            int maxSpeed;                 // field
            public void fullThrottle()    // method
            {
                Console.WriteLine("The car is going as fast as it can!");
            }

           public static void ObjectCarDisplay()
            {
                ObjectCar myObj = new ObjectCar();
                myObj.fullThrottle();  // Call the method
            }
        }

        // Object myCar
        
        public class ObjectMyCar
        {
           private string model; // field

            // create class constructor for the ObjectMyCar class
            public ObjectMyCar()
            {
                model = "Ford";
            }

            // create an object of the ObjectMyCar 
            public static void display()
            {
                ObjectMyCar OMC = new ObjectMyCar();

                Console.WriteLine(OMC.model);
            }


        }
        
        //Tính đóng gói

        // Properties
        public class Person
        {
            private string name;
            public string Name
            {
                get
                {
                    return name;

                }
                set
                {
                    name = value;
                }

            }
        }

        public class Program
        {
            public static void display()
            {
                Person person = new Person();
                person.Name = "Hieu";
                Console.WriteLine(person.Name);
            }

        }

        //Tính kế thừa

        public class Vehicle
        {
            public string branh = "Ford";
            public void honk()
            {
                Console.WriteLine("Tit, Tit");
            }
        }
         public class CarSecond : Vehicle
        {
            public string modeName = "Mustang";
        } 

        class ProgramSecond
        {
            public static void display()
            {
                CarSecond cs = new CarSecond();
                cs.honk();
                Console.WriteLine(cs.modeName + " : "+ cs.branh);
            }
        }

        //Tính đa hình
        public class Animal
        {
            public virtual void sound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        public class Pig:Animal
        {
            public override void sound()
            {
                Console.WriteLine("Go GO");
            }
        }
        public class Ben:Animal
        {
            public override void sound()
            {
                Console.WriteLine("Meo Meo");
            }
        }

        public class ProgramThree
        {
            public static void display()
            {
                Animal al = new Animal();
                Animal alPig = new Pig();
                Animal alBen = new Ben();

                al.sound();
                alPig.sound();
                alBen.sound();

            }
        }

        //Triều tượng 
          abstract class Animals
          {
            public abstract void animalSound();
            public  static  void Sleep()
            {
                Console.WriteLine("ZZZ");
            }
        }
         class Dog : Animals
        {
            public override void animalSound()
            {
                Console.WriteLine("Meo Meo");
            }
        }

        public class ProgramFourd
        {
          static void display()
            {
                Dog dg = new Dog();
                dg.animalSound();
                

            }
            
            
        }

        //Function tra ve hai gia tri
        public class Functions
        {
          
        }
    }
}
