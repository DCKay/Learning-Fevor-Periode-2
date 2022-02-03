using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaTime
{
    public class Pizza
    {
        private string _vulling;
        private int _diameter;
        private double _price;

        public Pizza(string vulling, int diameter, double price)
        {
            Vulling = vulling;
            Diameter = diameter;
            Price = price;
        }

        public string Vulling
        {
            get { return _vulling; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"{nameof(Vulling)}, Moet een geldige waarde hebben. Foute Waarde of NULL is niet aanvaard.");
                }
                _vulling = value;
            }
        }

        public int Diameter
        {
            get { return _diameter; }
            set
            {
                if (value < 10 || value > 30)
                {
                    throw new ArgumentException($"Diameter moet tussen 10 en 30 cm zijn. Uw waarden {value} is ongeldig", nameof(Diameter));
                }
                _diameter = value;
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Prijs kan niet negatief of 0 zijn", nameof(Price));
                }
                _price = value;
            }
        }

        // Dit kan beter in een Exception
        private void Failing(ArgumentException value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value.Message);
            Console.ResetColor();
            Console.ReadLine();
        }


        public override string ToString()
        {
            return $"Topping:{Vulling} Diameter:{Diameter} Prijs:{Price}";
        }
    }
}