using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Book.Session_9
{
    class Book
    {
        string bookName;
        long bookID;
        public Book( string bookName, long bookID)
        {
            this.bookName = bookName;
            this.bookID = bookID;
        }
        public string BookName
        {
            get
            {
                return bookName;
            }
        }
        public long BooKID
        {
            get
            {
                return bookID;
            }
            
        }
    }
}
