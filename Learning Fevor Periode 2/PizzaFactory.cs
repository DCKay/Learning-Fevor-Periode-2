using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaTime;

namespace Learning_Fevor_Periode_2
{
    public class PizzaFactory
    {
        private Pizza CreatePizza(int pizzaNumber)
        {
            Console.WriteLine("Geef een Pizza in:");

            Console.WriteLine($"Geef Topping in voor Pizza {pizzaNumber}:");
            string Vulling = Console.ReadLine();

            Console.WriteLine($"Geef de diameter tussen 10 en 30 in voor Pizza {pizzaNumber}:");
            int Diameter = int.Parse(Console.ReadLine());

            Console.WriteLine($"Geef de prijs in voor Pizza {pizzaNumber}:");
            double Price = double.Parse(Console.ReadLine());

            var pizza = new Pizza(Vulling, Diameter, Price);
            return pizza;
        }


        public IList<Pizza> AddPizzasToList(int amountOfPizzas)
        {
            Console.WriteLine($"Please enter {amountOfPizzas} amount of pizza's");

            IList<Pizza> pizzaList = new List<Pizza>();

            for (int i = 0; i < amountOfPizzas; i++)
            {
                Pizza pizza = CreatePizza(i + 1);
                pizzaList.Add(pizza);
            }

            return pizzaList;
        }

        public void PrintPizzas(IList<Pizza> pizzas)
        {
            Console.WriteLine("Uw bestelling:");
            foreach (Pizza pizza in pizzas
                         .OrderBy(o => o.Vulling)
                         .ThenBy(b => b.Diameter))
            {
                Console.WriteLine(pizza);
            }
        }
    }
}
