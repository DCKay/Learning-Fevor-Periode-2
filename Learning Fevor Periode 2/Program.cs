using PizzaTime;
using System;
using System.Collections.Generic;

namespace Learning_Fevor_Periode_2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            PizzaFactory factory = new PizzaFactory();

            Console.WriteLine("Pizza time!");
            Console.WriteLine("Hoeveel pizza's wenst u?");

            // TODO: Check input
            int amountOfPizzas = int.Parse(Console.ReadLine());

            // Best Practice: Hou methodes zoveel mogelijk uit elkaar.
            // Hoe meer methodes en klassen van elkaar gescheiden zijn, hoe beter ->
            // Seperation of Concerns, Loosely coupled words

            try
            {
                IList<Pizza> pizzas = factory.AddPizzasToList(amountOfPizzas);
                factory.PrintPizzas(pizzas);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.ReadLine();
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}