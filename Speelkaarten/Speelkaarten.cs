using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speelkaarten
{
    class Speelkaarten
    {
        public int Getal { get; set; }
        public Deck Deck { get; set; }
    }

    enum Deck
    {
        Ruiten,
        Klaveren,
        Harten,
        Schoppen
    }
}
