using System.Collections.Generic;
using System.Linq;

namespace Eigen_Huis
{
    internal class Huis
    {
        public List<Kamer> kamers { get; }

        public List<Kamer> GetKamers()
        {
            return kamers;
        }

        public double BerekenPrijs()
        {
            return GetKamers().Sum(i => i.Price);
        }

        /* tostring snippet project Stijn
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(new string('▬', 83));
            sb.AppendLine($"Huis met {Kamers.Count} kamers");
            sb.AppendLine(new string('▬', 83));
            foreach (var kamer in Kamers)
            {
                sb.AppendLine($"{kamer.GetType().Name,-25}:  {kamer.Name,-15} vierkante meter {kamer.Space.ToString(),-5} Prijs: {kamer.Price.ToString("N0").PadLeft(10, ' ')}");
            }
            sb.AppendLine(new string('─', 83));
            sb.AppendLine($"{"Totale Prijs",-25}: {BerekenPrijs().ToString("N0").PadLeft(56, ' ')}");
            sb.AppendLine(new string('▬', 83));
            return sb.ToString();
        }*/

        public override string ToString()
        {
            return base.ToString();
        }
    }
}