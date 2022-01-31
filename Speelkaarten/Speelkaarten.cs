using System;
using System.Collections.Generic;
using System.Linq;

namespace Speelkaarten
{
    internal enum Deck
    {
        Ruiten,
        Klaveren,
        Harten,
        Schoppen
    }

    internal class Speelkaarten
    {
        private Deck Deck { get; set; }
        private int Getal { get; set; }

        private List<Speelkaarten> CreateDeck()
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
            return fullDeck;
        }

        private void ShowCard(object fullDeck)
        {
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
        }

        public void Work()
        {
            ShowCard(CreateDeck());
        }
    }
}