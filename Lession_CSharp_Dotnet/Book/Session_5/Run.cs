using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Book.Session_5
{
    public static class Run
    {
        public static void Test()
        {
            //  bai_2();
            //  bai_3();
            bai_4();
        }
        // Create new  an array
       static void bai_1()
        {
             // int[] number = new int[5];
              string[] studNames = new string[4] {"Allan", "Wilson", "James", "Arnold"};
        }

        static void bai_2()
        {
            int[] count = new int[10];
            //array is created 
            int counter = 0;
            for(int i=0; i<10; i++) { 
                count [i] = counter++;
                //values are assigned to the elements 
                Console.WriteLine ("The count value is: " + count [i] );
                // element values are printed 
            }
        }
        // declaring and initializing
        //Single-array
        static void bai_3()
        {
            /*int[] array; //declaring 
            array = new int[5]; // initializing*/

            string[] students = new string[3] {"James", "Alex", "Fernando"};
            for (int i=0; i < students . Length; i++) {
                Console.WriteLine(students[i]);
            }
         }

       // multicast-Array
       static void bai_4()
        {
            /* int[,] array;
             array = new int[5,4];*/

            int[,] dimension = new int[4, 5];
            int numOne = 0;
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 5; j++) {
                    dimension[i, j] = numOne; 
                    numOne++; 
                }
            }
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 5; j++) {
                    Console.Write(dimension[i, j] + " .");
                }
             }
            Console.WriteLine();
        }

        //Rectangular Array
        static void bai_5()
        {
            Console.Write("Enter the number of Students: ");
            int noOfStds = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of Exams: ");
            int exams = Convert.ToInt32(Console.ReadLine());
            string[] sthame = new string[noOfStds];
            string[,] details = new string[noOfStds, exams];
            for (int i = 0; i < noOfStds; i++)
            {
                Console.WriteLine();
                Console.Write("Enter the Student Name: ");

                sthame[i] = Convert.ToString(Console.ReadLine());
                for (int y = 0; y < exams; y++)
                {
                    Console.Write("EnterScoreiJLExam" + (y + 1) + ": ");
                  
                }
            }
            Console.WriteLine(); Console.WriteLine("StudentExamDetails");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.WriteLine("Student\t\tMarks");
            Console.WriteLine("-----\t\t—------");
            for (int i = 0; i < sthame.Length; i++)
            {
                Console.WriteLine(sthame[i]);
                for (int j = 0; j < exams; j++)
                {
                    Console.WriteLine("\t\t" + details[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
 }
 
