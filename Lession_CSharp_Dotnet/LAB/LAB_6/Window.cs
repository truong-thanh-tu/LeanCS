using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.LAB.LAB_6
{
    class Window
    {
        protected int top;
        protected int left;
        // constructor takes two integers to 
        // fix location on the console 
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;

        }
        public  virtual void DrawWindow()
        {
            Console.WriteLine("Window : drawg Window at {0} {1}", top, left);
        }
    }
}
