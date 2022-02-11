using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class CoffeTableBook : Book
    {
        public CoffeTableBook(int iSBN, string Title, string Author) : base(iSBN, Title, Author)
        {
        }
        public override double Price
        {
            get
            {
                Random priceCoffeeTableBook = new Random();
                
                return priceCoffeeTableBook.Next(35,100);
            }
        }
        
    }
}
