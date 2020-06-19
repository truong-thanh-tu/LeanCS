using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Reseach.Laptrinhhuongdoituong
{
    class Class3
    {
        public static void Domain()
        {

            string filePath = "TextFile1.txt";

            string[] lines;
            string str;

            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine("Line {0}: {1}", i, lines[i]);
                }
                Console.WriteLine();

                str = System.IO.File.ReadAllText(filePath);
                Console.WriteLine("String: {0}", str);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
    }
}
