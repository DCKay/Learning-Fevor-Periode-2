using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class TextBook : Book
    {
        public int GradeLevel { get; set; }
        public TextBook(int iSBN, string Title, string Author, int GradeLevel) : base (iSBN, Title, Author)
        {
        }
        public override double Price
        {
            get
            {
                Random priceTextBook = new Random();

                return priceTextBook.Next(20, 80);
            }
        }
    }
}
