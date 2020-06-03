using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Book.Session_4
{
    public static class Run
    {
        public static void Test()
        {
            // bai_1();
            // bai_2();
            // bai_3();
            // bai_4();
            // bai_5();
            // bai_6();
            // bai_7();
            bai_8();
        }
        /// <summary>
        /// Dung cau lenh if else de kiem tra 
        /// </summary>
        static void bai_1()
        {
            int num = 10;
            if (num < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is positive");
            }
        }
        /// <summary>
        /// Dung cau lenh if else if de kiem tra 
        /// </summary>
        static void bai_2()
        {
            int num = 3;
            if (num < 0)
            {
                Console.WriteLine("The number is negative ");
            }
            else if ((num % 2) == 0)
            {
                Console.WriteLine("The number is even");
            }
        }
        ///<summary>
        ///  Khoi lenh if long if
        /// </summary>
        static void bai_3()
        {
            int yrsOfService = 3;
            double salary = 1500;
            int bonus = 0;
            if (yrsOfService < 5)
            {
                if (salary < 500)
                {
                    bonus = 100;
                }
                else
                {
                    bonus = 200;
                }
            }
            else { bonus = 700; }
            Console.WriteLine("Bonus amount: " + bonus);
        }
        /// <summary>
        /// Dung switch case để rẽ nhánh để kiểm tra
        /// </summary>
        static void bai_4()
        {
            int day = 5;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Enterianumberbetweentho7");
                    break;
            }
        }
        /// <summary>
        /// Nhap du lieu vao va dung switch case để kiểm tra 
        /// </summary>
        static void bai_5()
        {
            int numOne;
            int numTwo;
            int result = 0;
            Console.WriteLine("(1)Addition");
            Console.WriteLine("(2) Subtraction");
            Console.WriteLine("(3) Multiplication");
            Console.WriteLine("(4) Division");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value one");
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value two");
            numTwo = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    result = numOne + numTwo;
                    break;
                case 2:
                    result = numOne - numTwo;
                    break;
                case 3:
                    result = numOne * numTwo;
                    break;
                case 4:
                    Console.WriteLine("Do you want to calculate the quotient or remainder ? ");
                    Console.WriteLine("(l) Quotient");
                    Console.WriteLine("(2) Remainder");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            result = numOne / numTwo;
                            break;
                        case 2:
                            result = numOne % numTwo;
                            break;
                        default:
                            Console.WriteLine("Incorrect Choice");
                            break;
                    }
                    break;
                default: Console.WriteLine("Incorrect Choice"); break;
            }
            Console.WriteLine("Result: " + result);

        }
        ///<summary>
        /// Su dung vong lap While
        /// </summary>
        static void bai_6()
        {
            int num = 1;
            Console.WriteLine("Enter number");
            while (num < 10)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
                num++;
            }
        }
        /// <summary>
        /// Su dung vong lap while
        /// </summary>
        static void bai_7()
        {
            int i = 0;
            int j;
            while (i <= 5)
            {
                j = 0; while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine(); i++;
            }
        }
        ///<summary>
        /// Su dung vong lap for
        /// </summary>
        static void bai_8()
        {
            int num;
            Console.WriteLine("Even Numbers ");
            for (num = 1; num <= 11; num++)
            {
                if ((num % 2) == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }

    }
 }
