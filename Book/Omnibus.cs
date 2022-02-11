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
