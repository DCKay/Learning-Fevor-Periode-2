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

        public int ISBN { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public virtual double Price { get;}
    }
}
