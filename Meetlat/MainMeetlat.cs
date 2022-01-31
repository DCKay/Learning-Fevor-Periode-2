using System;

namespace Meetlat
{
    public class MainMeetlat
    {
        private static void Main(string[] args)
        {
            Meetlat meetlat = new Meetlat(0.05654864682);

            Console.WriteLine($"{meetlat.LengteInMeter} meter is {meetlat.LengteInMeter} m");
            Console.WriteLine($"{meetlat.LengteInMeter} meter is {meetlat.LengteInCm} cm");
            Console.WriteLine($"{meetlat.LengteInMeter} meter is {meetlat.LengteInKm} km");
            Console.WriteLine($"{meetlat.LengteInMeter} meter is {meetlat.LengteInVoet} ft");

            Console.ReadLine();
        }
    }
}