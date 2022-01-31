using System;

namespace Speelkaarten
{
    internal class MainSpeelkaarten
    {
        public static void Main(string[] args)
        {
            var kaartspel = new  Speelkaarten();
            kaartspel.Work();

            Console.WriteLine("bij de laatste had je zeker juist moeten hebben");

            Console.ReadLine();
        }
    }
}