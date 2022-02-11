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

        public override string ToString()
        {
            return $"Huis met {kamers.Count} kamers";
        }
    }
}