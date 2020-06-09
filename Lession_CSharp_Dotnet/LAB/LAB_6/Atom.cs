using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.LAB.LAB_6
{
    class Atom
    {
        private int number;
        private string symbol;
        private string fullName;
        private int weight;

        public Atom(int number, string symbol, string fullName, int weight)
        {
            this.number = number;
            this.symbol = symbol;
            this.fullName = fullName;
            this.weight = weight;

        }
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                this.number = number;
            }
        }
        public string Sysbol
        {
            get
            {
                return symbol;
            }
            set
            {
                this.symbol = symbol;
            }
        }
        public string FullNames
        {
            get
            {
                return fullName;
            }
            set
            {
                this.fullName = fullName;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                this.weight = weight;
            }
        }
       
    }
   
}
