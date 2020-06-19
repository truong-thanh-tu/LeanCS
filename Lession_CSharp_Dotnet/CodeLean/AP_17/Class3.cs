using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.CodeLean.AP_17
{
    class Class3
    {
        static FileStream Fs; static StreamWriter sw;
        // delegate declaration 
        public delegate void printString(string s);
        // this method prints to the console 
        public static void WriteToScreen(string str)
        { 
            Console.WriteLine("The String is: {0}", str);
        }
        //this method prints to a File
        public static void WriteToFile(string s) {
            Fs = new FileStream("Message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(Fs); sw.WriteLine(s); sw.Flush(); sw.Close(); Fs.Close();
        } 
        // this method takes the delegate as parameter and uses it to
        // call the methods as required 
        public static void sendString(printString ps) 
        { 
            ps("Hello World");
        }
        public static void Display()
        {
            printString psl = new printString(WriteToScreen);
            printString ps2 = new printString(WriteToFile);
            sendString(psl); sendString(ps2);
            Console.ReadKey();
        }
    }
}
