using System;

namespace Meetlat
{
    /*
     * Maak een klasse “Meetlat”. Via een property LengteInMeter kan de gebruiker de lengte van een voorwerp instellen (in meter).
     * Via een reeks read-only properties (die transformeren) kan de gebruiker deze lengte in verschillende eenheden uitlezen namelijk:
     * LengteInM, LengteInCm, LengteInKm, LengteInVoet (1m= 3.2808ft)
     * Opgelet het readonly keyword heb je niét nodig om readonly properties te maken. Zoek op hoe je dit wel doet.
     */

    public class Meetlat
    {
        private double _lengteInMeter;

        public Meetlat(double beginLengteInMeter)
        {
            _lengteInMeter = beginLengteInMeter;
        }

        // Get readonly value
        public double LengteInMeter => _lengteInMeter;

        public double LengteInCm => Math.Round(_lengteInMeter * 100, 2);

        public double LengteInKm => _lengteInMeter / 1000;

        public double LengteInVoet => _lengteInMeter * 3.2808;
    }
}