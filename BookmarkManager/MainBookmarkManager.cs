using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookmarkManager;

namespace BookmarkManager
{
    class MainBookmarkManager
    {
        static void Main(string[] args)
        {
            BookmarkManager u = new BookmarkManager();
            u.URL = "https://www.learningfever.be";

            u.OpenSite();

            Console.ReadLine();
        }
    }
}
