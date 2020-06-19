using Lession_CSharp_Dotnet.Reseach.HomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Book.Session_9
{
    class doMain
    {
        public static void diplay()
        {
            /*Student st = new Student();
            st.StudentsID = 123;
            st.StudentsName = "Thanh Tu";
            st.StudentsScores = 10;
            Console.WriteLine("ID Student     : {0}",st.StudentsID);
            Console.WriteLine("Name Student   : {0}",st.StudentsName);
            Console.WriteLine("Scores Student : {0}",st.StudentsScores);*/

            Book bk = new Book("Learn C# in 21 days",10015);
           

            Console.WriteLine("Book Name : {0}",bk.BookName);
            //Console.WriteLine("Book ID   : {0}",bk.BookID);
        }
    }
}
