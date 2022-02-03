using System;
using System.Collections.Generic;

namespace Het_Dierenrijk
{
    internal class Program
    {
        public static IList<IAnimal> GenerateAnimals()
        {
            IList<IAnimal> animalList = new List<IAnimal>();

            IAnimal dog = new Dog
            {
                Name = "Spot"
            };
            IAnimal cat = new Cat
            {
                Name = "Felix"
            };
            IAnimal bunny = new Bunny();
            IAnimal skunk = new Skunk();

            animalList.Add(dog);
            animalList.Add(cat);
            animalList.Add(bunny);
            animalList.Add(skunk);

            return animalList;
        }

        public static void PrintAnimals(IList<IAnimal> animals)
        {
            Console.WriteLine("Catalogus:");
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine($"Naam: {animal.Name}");
                Console.WriteLine($"Leeftijd: {animal.Age}");

                Carnivore carnivore = animal as Carnivore;

                if (carnivore != null)
                {
                    Console.WriteLine($"Favorite prooi: {string.Join(",",carnivore.FavoritePrey)}");
                }
            }
        }

        private static void Main(string[] args)
        {
            IList<IAnimal> animals = GenerateAnimals();
            PrintAnimals(animals);
            Console.ReadLine();
        }
    }
}