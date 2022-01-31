using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaTime
{
    internal class Pizza
    {
        string vulling;
        int diameter;
        double price;

        private void Filling(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"{nameof(Vulling)}, Moet een geldige waarde hebben. Foute Waarde of NULL is niet aanvaard.");
            }
            vulling = value;
        }

        private void Sizing(int value)
        {
            if (value < 10 || value > 30)
            {
                throw new ArgumentException($"Diameter moet tussen 10 en 30 cm zijn. Uw waarden {value} is ongeldig", nameof(Diameter));
            }
            diameter = value;
        }

        private void Pricing(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Prijs kan niet negatief zijn", nameof(Price));
            }
            price = value;
        }

        private void Failing(ArgumentException value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value.Message);
            Console.ResetColor();
            Console.ReadLine();
        }

        public void AddPizza()
        {
            Console.WriteLine("Geef 3 Pizza's in:");

            List<Pizza> order = new List<Pizza>();

            while (order.Count < 3)
            {
                Console.WriteLine($"Geef Topping in voor Pizza {order.Count + 1}:");
                vulling = Console.ReadLine();
                Console.WriteLine($"Geef de diameter tussen 10 en 30 in voor Pizza {order.Count + 1}:");
                diameter = int.Parse(Console.ReadLine());
                Console.WriteLine($"Geef de prijs in voor Pizza {order.Count + 1}:");
                price = double.Parse(Console.ReadLine());
                try
                {
                    var pizza = new Pizza()
                    {
                        Vulling = vulling,
                        Diameter = diameter,
                        Price = price
                    };
                    order.Add(pizza);
                }
                catch (ArgumentException ex)
                {
                    Failing(ex);
                }

                Console.Clear();
                Console.WriteLine("Uw bestelling:");
                foreach (var pizza in order.OrderBy(o => o.Vulling).ThenBy(b => b.Diameter))
                {
                    Console.WriteLine(pizza);
                }
            }
        }

        public string Vulling
        {
            get { return vulling; }
            set
            {
                Filling(vulling);
            }
        }

        public int Diameter
        {
            get { return diameter; }
            set
            {
                Sizing(diameter);
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                Pricing(Price);
            }
        }

        public override string ToString()
        {
            return $"Topping:{Vulling} Diameter:{Diameter} Prijs:{Price}";
        }
    }
}