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
                Name = "Spot",
                Age = 2
            };
            IAnimal cat = new Cat
            {
                Name = "Felix",
                Age = 1
            };
            IAnimal bunny = new Bunny
            { 
                Name = "Gerecht",
                Age = 0
            };
            IAnimal skunk = new Skunk
            {
                Name = "Skunky",
                Age = 5
            };

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
                Console.WriteLine();
                animal.Intro();
                Console.WriteLine($"Naam: {animal.Name}");
                Console.WriteLine($"Leeftijd: {animal.Age}");

                Carnivore carnivore = animal as Carnivore;

                if (carnivore != null)
                {
                    Console.WriteLine($"Favorite voedsel: {string.Join(",",carnivore.FavoritePrey)}");
                    Console.WriteLine($"Gevaarlijk:{carnivore.IsDangerous}");
                }

                Herbivore herbivore = animal as Herbivore;

                if (herbivore != null)
                {
                    Console.WriteLine($"Favorite voedsel: {string.Join(",", herbivore.FavoriteFood)}");
                    Console.WriteLine($"Gevaarlijk:{herbivore.IsDangerous}");
                }

                Omnivore omnivore = animal as Omnivore;

                if (omnivore != null)
                {
                    Console.WriteLine($"Favorite voedsel: {string.Join(",", omnivore.FavoriteFood)}");
                    Console.WriteLine($"Gevaarlijk:{omnivore.IsDangerous}");
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