using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.LAB.LAB_6
{
    class Button:Window
    {
        public Button(int top, int left) : base(top, left)
        {
        }
        // an overridden version (note keyword) because in the 
        // derived method we change the behavior 
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0}, {l}\n", top, left);
        }
    }
}
