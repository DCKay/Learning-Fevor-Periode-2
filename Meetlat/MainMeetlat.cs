using System;

namespace Meetlat
{
    internal class MainMeetlat
    {
        private static void Main(string[] args)
        {
            Meetlat meetlat = new Meetlat(2);

            Console.WriteLine($"{meetlat.BeginLengte} meter is {meetlat.LengteInM} m");
            Console.WriteLine($"{meetlat.BeginLengte} meter is {meetlat.LengteInCm} cm");
            Console.WriteLine($"{meetlat.BeginLengte} meter is {meetlat.LengteInKm} km");
            Console.WriteLine($"{meetlat.BeginLengte} meter is {meetlat.LengteInVoet} ft");

            Console.ReadLine();
        }
    }
}