using System;

namespace Het_Dierenrijk
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Intro()
        {
            Console.WriteLine("Hallo, ik ben een dier");
        }
    }

    public abstract class Carnivore : Animal
    {
        public string[] FavoritePrey { get; set; }
        public bool IsDangerous { get; set; }

        public override void Intro()
        {
            Console.WriteLine("Ik ben een dier en eet graag vlees.");
        }
    }

    public abstract class Herbivore : Animal
    {
        public string[] FavoriteFood { get; set; }
        public bool IsDangerous { get; set; }

        public override void Intro()
        {
            Console.WriteLine("Ik ben een dier en eet graag planten.");
        }
    }

    //TODO Compositie
    public abstract class Omnivore : Animal
    {
        public string[] FavoriteFood { get; set; }
        public bool IsDangerous { get; set; }
        public override void Intro()
        {
            base.Intro();
            Console.WriteLine("Ik eet graag alles!");
        }
    }

    public class Dog : Carnivore
    {
        public Dog()
        {
            FavoritePrey = new[] { "Cats", "Dogfood" };
            IsDangerous = false;
        }
        public override void Intro()
        {
            base.Intro();
            Console.WriteLine("Ik ben een hond. Mijn kleinste vorm weegt slechts 113 gram.");
            Console.WriteLine();
        }
    }

    public class Cat : Carnivore
    {
        public Cat()
        {
            FavoritePrey = new[] { "birds", "mice" };
            IsDangerous = false;
        }

        public override void Intro()
        {
            base.Intro();
            Console.WriteLine("Ik ben een kat. Als ik val, landt ik bijna altijd op mijn pootjes");
            Console.WriteLine();
        }
    }

    public class Bunny : Herbivore
    {
        public Bunny()
        {
            FavoriteFood = new[] { "Lettuce" };
            IsDangerous = false;
        }

        public override void Intro()
        {
            base.Intro();
            Console.WriteLine("Ik ben een konijn en vergis me niet met een knaagdier!");
            Console.WriteLine();
        }
    }

    public class Skunk : Omnivore
    {
        public Skunk()
        {
            FavoriteFood = new[] { "Insects" };
            IsDangerous = true;
        }
        public override void Intro()
        {
            base.Intro();
            Console.WriteLine("Ik ben een stinkdier, ik stink alleen als ik me bedreigd voel.");
            Console.WriteLine();
        }
    }
}