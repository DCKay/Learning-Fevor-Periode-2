using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Speelkaarten;

namespace Speelkaarten
{
    class MainSpeelkaarten
    {
        static void Main(string[] args)
        {
            List<Speelkaarten> fullDeck = new List<Speelkaarten>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    Speelkaarten toAdd = new Speelkaarten() { Getal = j, Deck = (Deck)i };
                    fullDeck.Add(toAdd);
                }
            }

            Random random = new Random();

            while (fullDeck.Count > 0)
            {
                Console.WriteLine("Random Kaart");
                Speelkaarten nextInLine = fullDeck[random.Next(0, fullDeck.Count)];
                Console.WriteLine($"{nextInLine.Deck}  {nextInLine.Getal} " + $"\nWas dit uw kaart?");

                fullDeck.Remove(nextInLine);
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("bij de laatste had je zeker juist moeten hebben");


            Console.ReadLine();
        }
    }
}
