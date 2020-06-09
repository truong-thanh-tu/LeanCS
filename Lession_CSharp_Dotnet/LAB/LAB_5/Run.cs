using System;

namespace Lession_CSharp_Dotnet.LAB.LAB_5
{
    class Run
    {
        public static void Test()
        {
            //  Display();
            IndexerDemo.Display();
        }
        // Abstract class and properties demo
        public abstract class GeometricObject
        {
            protected String color;
            protected double weight;

            protected GeometricObject()
            {
                color = "white"; weight = 1.0; 
            }
            // Default construct
            protected GeometricObject(String color, double weight)
            {
                this.color = color;
                this.weight = weight;
            }
            //properties 
            public string PColor
            {
                get
                {
                    return color;
                }
                set
                {
                    color = value;
                }
            }
            public double PWeight
            {
                get
                {
                    return weight;
                }
                set
                {
                    weight = value;
                }
            }
            // Abstract method
            public abstract double findAre();
            // Abstract method
            public abstract double findPerimeter();
        }

        //Circle class extends  GeometricObject.cs

        public class Circle : GeometricObject
        {
            private double radius;
            public Circle(double x)
            {
                this.radius = x;
            }
            public Circle(double x, string c, double w) : base(c, w)
            {
                this.radius = x;
            }
            public override String ToString()
            {
                return "Circle has: radius is " + radius + ", color is " + PColor + ", weight is " + PWeight;
            }
            public override double findAre()
            {
                return Math.PI * radius * radius;
            }
            public override double findPerimeter()
            {
                return 2 * Math.PI * radius;
            }


        }

        //Display
        public static void Display()
        {
            Circle C1 = new Circle(2.45, "Blue", 23);
            Console.WriteLine("Circle before change: " + C1.ToString());
            //using properties
            C1.PColor = "red";
            C1.PWeight = 2.56;
            Console.WriteLine("Circle after change: " + C1.ToString());
            Console.ReadLine();
        }

        //Indexer 
        class IndexerExample
        {
            public int[] intList = new int[10];
            public int this[int index]
            {
                get
                {
                    return intList[index];
                }
                set
                {
                    intList[index] = value;
                }
            }
        }
        public  class IndexerDemo
        {
            public static void Display()
            {
                int i, j = 0;
                IndexerExample indexTest = new IndexerExample();
                for( i = 1; i < 10; i++)
                {
                    indexTest[j] = i;
                    j++;
                }
                for(i = 0; i < 5; i++)
                {
                    Console.WriteLine("IndexText[{0}] is {1}",i, indexTest[i]);
                    Console.ReadLine();
                }
            }
        }
    }

}
