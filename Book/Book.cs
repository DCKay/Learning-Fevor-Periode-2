using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Book
    {
        protected Book(int iSBN, string title, string author)
        {
            ISBN = iSBN;
            Title = title;
            Author = author;
        }

        protected Book(int iSBN, string title, string author, double price) : this(iSBN, title, author)
        {
            Price = price;
        }

        public int ISBN { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        private double price;

        public virtual double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }

    }
}
