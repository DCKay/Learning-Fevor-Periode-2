namespace Meetlat
{
    internal class Meetlat
    {
        private decimal lengte;

        public Meetlat(decimal beginLengte)
        {
            lengte = beginLengte;
        }

        public decimal BeginLengte
        {
            get { return lengte; }
        }

        public decimal LengteInM => lengte; 

        public decimal LengteInCm => lengte * 100;

        public decimal LengteInKm => lengte / 1000;

        public decimal LengteInVoet => lengte * 3.2808M;
    }
}