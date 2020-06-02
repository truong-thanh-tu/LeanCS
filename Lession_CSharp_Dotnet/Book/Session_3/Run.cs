using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Book.Session_3
{
    public static class Run
    {
        public static void Test()
        {
            //  bai_1();
            //  bai_2(); 
            //  bai_3();
            //  bai_4();
            //  bai_5();
            //  bai_6();
            //  bai_7();
            //  bai_8();
            //  bai_9();
            bai_10();
            Console.ReadKey();
        }
        // Tinh dien tich
        static void bai_1()
        {
            int side = 10;  int height = 5;
            double area = 0.5*side*height;
            Console.WriteLine("Area  = {0}" , area);
        }
        // Dung checkup de kiem tra ket qua co vuoc qua gioi han hay khong
        static void bai_2()
        {
            byte numOne = 255;
            byte numTwo = 1;
            byte result = 0; 
            try
            { 
                //This code throws an overflow exception 
                checked { 
                    result = (byte) (numOne + numTwo);
                } 
                Console.WriteLine("Resultz = "+result);
            } catch(OverflowException ex)
            { 
                Console.WriteLine(ex);
            }
        }
        // Dung uncheckup de bo qua cac truong hop ngooai len
        static void bai_3()
        {
            byte numOne = 255;
            byte numTwo = 1;
            byte result = 0;
            try
            {
                unchecked
                {
                    result = (byte)(numOne + numTwo);
                }
                Console.WriteLine("Resultz = "+result);
            } catch (OverflowException ex) { Console.WriteLine(ex); }
        }
        //  Thuc hien khai bao va tinh toan roi hien thi ra mang hinh
        static void bai_4()
        {
            int valueOne = 10;
            int valueTwo = 2;
            int add = valueOne + valueTwo;
            int sub = valueOne - valueTwo;
            int mult = valueOne * valueTwo;
            int div = valueOne / valueTwo;
            int modu = valueOne % valueTwo;
            Console.WriteLine("Addition " +add);
            Console.WriteLine("Subtraction " +sub);
            Console.WriteLine("Multiplication " +mult);
            Console.WriteLine("Division " +div);
            Console.WriteLine("Remainder " +modu);
        }
        // Thuc hien toan tu so sanh
        static void bai_5()
        {
            int leftVal = 50;
            int rightVal = 100;
            Console.WriteLine("Equalz " + (leftVal == rightVal) )
                ; Console.WriteLine ("Not Equal: " + (leftVal != rightVal) ) ;
            Console.WriteLine("Greaterz " +(leftVal > rightVal));
            Console.WriteLine("Lesserz " + (leftVal < rightVal) );
            Console .WriteLine ("Greater or Equal: " + (leftVal >= rightVal) ) ;
            Console .WriteLine ("Lesser or Equal: " + (leftVal <= rightVal) ) ;
        }
        // Dung if else de kiem tra dieu kien 
        static void bai_6()
        {
            int num = 0;
            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("The number exists between 1 and 10");
            }
            else { 
                Console.WriteLine("The number does not exist between 1 and 10");
            }
        }
        // Dung if else de kiem tra dieu kien 
        static void bai_7()
        {
            int num = -5;
            if (num < 0 || num > 10)
            { 
                Console.WriteLine("The number does not exist between 1 and 10");
            } else
            {
                Console.WriteLine("The number exists between 1 and 10");
            }
         }
        // Dung toan tu 
        static void bai_8()
        {
            int valueOne = 5;
            int valueTwo = 10;
            Console.WriteLine("Valuel = " +valueOne);
            valueOne += 4;
            Console.WriteLine("Valuel += 4: " +valueOne);
            valueOne -= 8;
            Console.WriteLine("Valuel -= 8: " +valueOne);
            valueOne *= 7;
            Console.WriteLine("Valuel *= 7 = " +valueOne);
            valueOne /= 2; 
            Console.WriteLine("Valuel /= 2 = " +valueOne);
            Console.WriteLine("Valuel == Value2: {0} ", (valueOne == valueTwo) ) ;
        }
        // Ternary or conditional
        static void bai_9()
        {
            int numOne = 5;
            int numTwo = 25;
            int numThree = 15;
            int result = 0;
            if (numOne > numTwo)
            {
                result = (numOne > numThree) ? result = numOne : result = numThree;
            }
            else 
            {
                result = (numTwo > numThree) ? result = numTwo : result = numThree; 
            }
            if ( result != 0)
            {
                Console.WriteLine("{0}  is the largest number", result);

            }
        }
        // Dung ham 
        static void bai_10()
        {
            int num = 8;
            int result;
            result = Square (num);
            Console.WriteLine("Square of {0} = {1}",num,result);
        }
        static int Square (object inum) { 
            return (int) inum * (int) inum;
        }
    }
}
