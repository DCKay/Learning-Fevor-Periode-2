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
        private List<Book> omnibus { get; }

        public List<Book> GetOmnibus()
        {
            i = +1;
            return omnibus;
        }

        public double GetPrice()
        {
            return GetOmnibus().Sum(i => i.Price);
        }

        public override string ToString()
        {
            return $"Omnibus met {omnibus.Count} boeken";
        }
    }
}
