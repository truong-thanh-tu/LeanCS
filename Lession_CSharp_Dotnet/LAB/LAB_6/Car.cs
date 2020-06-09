using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.LAB.LAB_6
{
    class Car
    {

        public string make;
        public string model;
        public string color;
        public int yearBuuilt;

        public void Start()
        {
            Console.WriteLine(model + "started");
        }

        public void Stop()
        {
            Console.WriteLine(model + "stopped");
        }
    }
}
