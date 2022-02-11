using System;

namespace Eigen_Huis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Huis blauwdruk1 = new Huis();
            Huis blauwdruk2 = new Huis();

            blauwdruk1.GetKamers().AddRange(new Kamer[]
            {
                new Badkamer("badkamer", 10),
                new Gang("gang", 12),
                new Salon("salon", 36, true)
            });

            blauwdruk2.GetKamers().AddRange(new Kamer[]
            {
                new Badkamer("badkamer", 20),
                new Gang ("gang", 8),
                new Salon("living", 41, false)
            });


            Console.WriteLine(blauwdruk1.ToString());
            Console.WriteLine(blauwdruk2.ToString());
            Console.ReadLine();
        }
    }
}