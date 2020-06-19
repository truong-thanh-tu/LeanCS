using Lession_CSharp_Dotnet.Book.Session_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_CSharp_Dotnet.Book.Session_9
{
    class Product
    {
        string productName;
        int productID;
        long productPrice;

        public Product(string productName, int productID, long productPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.productPrice = productPrice;
        }
        public string ProductPrice
        {
            set
            {
                if(productPrice < 0)
                {
                    productPrice = 0;
                }
                else
                {
                    this.productPrice = Convert.ToInt32(value) ; 
                }
            }
        }
    
    }
}
