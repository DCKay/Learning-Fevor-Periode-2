using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Omnibus omnibus = new Omnibus();

            omnibus.GetOmnibus().AddRange(new Book[]{
                new TextBook(1, "Coding for Dummies", "Kay", 420),
                new CoffeTableBook(2, "Coffee for Dummies", "Coffee Guy")
            });

            Console.WriteLine(omnibus.ToString());
        }
    }
}
