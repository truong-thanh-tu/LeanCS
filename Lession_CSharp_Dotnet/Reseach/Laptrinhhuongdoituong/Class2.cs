using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Reseach.Laptrinhhuongdoituong
{
    class Class2
    {
        private int top ;
        private int[] s;
       
        public bool full()
        {
            return top >= s.Length;
        }
        public bool empty()
        {
            return top == -1;
        }
        public void stack()
        {
            s = new int[20];
            top = -1;
        }
        public void push(int x)
        {
            if (!full())
            {
                top = top + 1;
                s[top] = x;
            }
            else
            {
                Console.WriteLine("Stack tran");
            }
        }
        public int pop()
        {
            if (empty())
            {
                Console.WriteLine("Stack can");
                return 0;
            }
            else
            {
                return s[top--];
            }
        }

    }
}
