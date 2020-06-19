using System;

namespace Lession_CSharp_Dotnet.LAB.LAB_6
{
    class Run
    {
        public static void Test()
        {
            Atom[] at = new Atom[2];
            for (int i = 0; i < 2; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                string symbol = Console.ReadLine();
                string fullName = Console.ReadLine();
                int weight = Convert.ToInt32(Console.ReadLine());

                at[i] = new Atom(number, symbol, fullName, weight);
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(at[i].Number + " " + at[i].Sysbol + " " + at[i].FullNames + " " + at[i].Weight);
            }
            Console.ReadKey();
        }
        public static void Test1(){

        }
    }
}
