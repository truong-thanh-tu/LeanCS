using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Book.Session_6
{
     public static class Run
    {
        // Hàm gọi hàm 
        public static void Test()
        {
            //   Car.Runs();
            //   MyClass.fullThrottle();
            //   MyCar.yourCar();
            //   CarOne.display();
            //   ObjectCar.ObjectCarDisplay();
            //   ObjectMyCar.display();
            //   Program.display();
            //   ProgramSecond.display();
            //   ProgramThree.display();
            //   Students.displayScreen();
            //   Book.Display();
            //   MyStudent.Display();
            //   OptionalParameterExample.Display();

        }

        // Class Car
        public class Car
        {
            //Thuộc tính của Car
            String color = "red";
            String color1 = "black";

            //Phương thức Car hiển thị 
            public static void Runs()
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

            public static void yourCar()
            {
                Console.WriteLine("name : {0}; maxSpeed : {1}; color : {2} ", MyCar.name, MyCar.maxSpeed, MyCar.color);
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
                                  "Year  : {2};", Ford.model, Ford.color, Ford.year);
            }
        }

        // Class Students
        public class Students
        {
            string _student = "James Anderson";
            int _studAge = 27;

            void Display()
            {
                Console.WriteLine("Student Name: "+_student);
                Console.WriteLine("Student Age : "+_studAge);
            }

            void Input()
            {
                Console.WriteLine("Enter name student: ");
                _student = Console.ReadLine();
                Console.WriteLine("Enter age student: ");
                string age = Console.ReadLine();
                _studAge = Convert.ToInt32(age);
            }
            public static void displayScreen()
            {
                Students students = new Students();
                students.Input();
                students.Display();
            }
        }

        // Class MyStudent
        public class MyStudent
        {
          public void PrintName(String firstName, String lastName)
            {
                Console.WriteLine("First Name = {0}, Last Name = {1}", firstName, lastName);
            }

             public static void Display()
            {
                MyStudent myStudent = new MyStudent();
                myStudent.PrintName( firstName : "Henry", lastName: "Parker");
                myStudent.PrintName(lastName: "Parker", firstName: "Henry");
                myStudent.PrintName("Henry", lastName: "Parker");
                myStudent.PrintName("Parker", "Henry");
               // myStudent.PrintName(lastName : "Henry", "Perker");
            }
        }
       
        //Class Book 
        public class Book
        {
            string _bookName;
            int _price;

            public string Print()
            {
                return _bookName;
            }

            public int PrintPrice()
            {
                return _price;
            }
            public void Input (string bkname)
            {
                _bookName = bkname;
            }

            public void InputPrice ( int price)
            {
                _price = price;
            }
           public static void Display()
            {
                Book objBook = new Book();
                objBook.Input("C# -The complete reference");
                objBook.InputPrice(25000);
                Console.WriteLine(objBook.Print());
                Console.WriteLine(objBook.PrintPrice());
            }

        }

        //Class OptionalParameterExample
        class OptionalParameterExample
        {
            public void printMessage(string message = "Hello user!")
            {
                Console.WriteLine("{0}",message);
            }

            public static void Display()
            {
                OptionalParameterExample OPE = new OptionalParameterExample();
                OPE.printMessage();
                OPE.printMessage("Welcome User !");
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
                Console.WriteLine(cs.modeName + " : " + cs.branh);
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

        public class Pig : Animal
        {
            public override void sound()
            {
                Console.WriteLine("Go GO");
            }
        }
        public class Ben : Animal
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
            public static void Sleep()
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
    }
}
