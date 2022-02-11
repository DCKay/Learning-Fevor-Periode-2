using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Omnibus
    {
        private int i;
        public List<Book> Books { get; }
        public Omnibus()
        {
            Books = new List<Book>();
        }

        public double TelOp(Book a, Book b)
        {
            double totalePrijs = a.Price + b.Price;
            return totalePrijs / 2;
        }

        public double TelOp(List<Book> books)
        {
            double totalePrijs = 0;

            foreach (var book in books)
            {
                totalePrijs += book.Price;
            }
            double gemiddeldePrijs = totalePrijs / books.Count;
            return gemiddeldePrijs;
        }
        public double GetPrice()
        {
            return Books.Sum(i => i.Price);
        }

        public override string ToString()
        {
            return $"Omnibus met {Books.Count} boeken";
        }
    }
}
