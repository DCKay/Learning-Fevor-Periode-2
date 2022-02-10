using System;

namespace Eigen_Huis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Huis blauwdruk = new Huis();

            blauwdruk.GetKamers().AddRange(new Kamer[]
            {
                new Badkamer("badkamer", 10),
                new Gang("gang", 12),
                new Salon("salon", 36, true)
            });

            Console.WriteLine(blauwdruk.ToString());
            Console.ReadLine();
        }
    }
}