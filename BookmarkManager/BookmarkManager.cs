using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmarkManager
{
    class BookmarkManager
    {
        public string NaamWebsite { get; set; }
        public string URL { get; set; }

        public void OpenSite()
        {
            Process.Start(@"C:\Users\Imazo\AppData\Local\BraveSoftware\Brave-Browser\Application\brave.exe", URL);
        }
    }
}
