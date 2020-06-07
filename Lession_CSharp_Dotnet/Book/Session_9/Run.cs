using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Book.Session_9
{
    class Run
    {
        //Perform program
        public static void Test()
        {
            // SalaryDetail.Display();
            // Books.BookStore.Display();
            // Company.Display();
            // Product.Goods.Display();
            // Physics.Display();
            // Rectangle.Display();
            SalaryDetail.Display();
        }
        // Get and set accessors
        class SalaryDetail
        {
            private string _empName;
            public string EmployeeName
            {
                get
                {
                    return _empName;
                }
                set
                {
                    _empName = value;
                }
            }
            public static void Display()
            {
                SalaryDetail objSal = new SalaryDetail();
                objSal.EmployeeName = "Patrick Johnson";
                Console.WriteLine("Employee Name: " + objSal.EmployeeName);
            }
        }

        //read - only property
        class Books
        {
            private string _bookName;
            private long _bookID;

            public Books(string name, int value)
            {
                _bookName = name;
                _bookID = value;
            }
            public string BookName
            {
                get
                {
                    return _bookName;
                }
            }
            public long BookID
            {
                get
                {
                    return _bookID;
                }
            }
            public static class BookStore
            {
                public static void Display()
                {
                    Books objBook = new Books("Learn C# in 21 Days", 10015);
                    Console.WriteLine("Book Name: " + objBook.BookName);
                    Console.WriteLine("Book ID: " + objBook.BookID);
                }
            }
        }

        //write - only property
        class Department
        {
            string _deptName;
            int _deptID;
            public string DeptName
            {
                set
                {
                    _deptName = value;
                }
            }
            public int DeptID
            {
                set
                {
                    _deptID = value;
                }
            }
            public void Display()
            {
                Console.WriteLine("Department Name: " + _deptName);
                Console.WriteLine("Department ID: " + _deptID);
            }
        }
        class Company
        {
            public static void Display()
            {
                Department objDepartments = new Department();
                objDepartments.DeptID = 201;
                objDepartments.DeptName = "Sales";
                objDepartments.Display();
            }
        }

        // write - reade  property
        class Product
        {
            String _productName;
            int _productID;
            float _price;
            public Product(string name, int val)
            {
                _productName = name;
                _productID = val;
            }
            public float Price
            {
                get
                {
                    return _price;
                }
                set
                {
                    if (value < 0)
                    {
                        _price = 0;
                    }
                    else
                    {
                        _price = value;
                    }
                }
            }
            public void Display()
            {
                Console.WriteLine("Product Name: " + _productName);
                Console.WriteLine("Product ID: " + _productID);
                Console.WriteLine("Price: " + _price + "$");
            }
            public static class Goods
            {
                public static void Display()
                {
                    Product objProduct = new Product("Hard Disk", 101);
                    objProduct.Price = 345.25F;
                    objProduct.Display();
                }
            }
        }

        //Static property
        class University
        {
            private static string _department;
            private static string _universityName;
            public static string Department
            {
                get
                {
                    return _department;
                }
                set
                {
                    _department = value;
                }
            }
            public static string UniversityName
            {
                get
                {
                    return _universityName;
                }
                set
                {
                    _universityName = value;
                }
            }
        }

        class Physics
        {
            public static void Display()
            {
                University.UniversityName = "Universityof Maryland";
                University.Department = "Physics";
                Console.WriteLine("University Name: " + University.UniversityName);
                Console.WriteLine("Department name: " + University.Department);
            }
        }

        //Abstract Properties
        public abstract class Figure
        {
            public abstract float DimensionOne
            {
                set;
            }
            public abstract float DimensionTwo
            {
                set;
            }
        }
        class Rectangle : Figure
        {
            float _dimensionOne;
            float _dimensionTwo;
            public override float DimensionOne
            {
                set
                {
                    if (value <= 0)
                    {
                        _dimensionOne = 0;
                    }
                    else
                    {
                        _dimensionOne = value;
                    }
                }
            }
            public override float DimensionTwo
            {
                set
                {
                    if (value <= 0)
                    {
                        _dimensionTwo = 0;
                    }
                    else { _dimensionTwo = value; }
                }
            }
            float Area()
            {
                return _dimensionOne * _dimensionTwo;
            }
            public static void Display()
            {
                Rectangle objRectangle = new Rectangle();
                objRectangle.DimensionOne = 20;
                objRectangle.DimensionTwo = 4.2335F;
                Console.WriteLine("Area of Rectangle: " + objRectangle.Area());
            }
        }

        //Impletement Inheritance 
        public class Employee
        {
            string _empName;
            int _empID;
            float _salary;
            public string EmpName
            {
                get
                {
                    return _empName;
                }
                set
                {
                    _empName = value;
                }
            }
            public int EmpID
            {
                get
                {
                    return _empID;
                }
                set
                {
                    _empID = value;
                }
            }
            public float Salary
            {
                get
                {
                    return _salary;
                }
                set
                {
                    if (value < 0)
                    {
                        _salary = 0;
                    }
                    else
                    {
                        _salary = value;
                    }
                }
            }


        }
        class SalaryDetails : Employee
        {
            public static void Display()
            {
                SalaryDetails objSalary = new SalaryDetails();
                objSalary.EmpID = 10;
                objSalary.Salary = 1000.25F;
                Console.WriteLine("Name: " + objSalary.EmpName);
                Console.WriteLine("ID: " + objSalary.EmpID);
                Console.WriteLine("Salary: " + objSalary.Salary + "$");
            }
        }
    }
}
