using System;
using System.Linq;
using System.IO;
using GeoCoordinatePortable;


namespace LoggingKata
{
    class Program
    {
        static readonly ILog logger = new TacoLogger();
        const string csvPath = "TacoBell-US-AL.csv";

        static void Main(string[] args)
        {

            logger.LogInfo("Log initialized");

            var lines = File.ReadAllLines(csvPath);

            logger.LogInfo($"Lines: {lines[0]}");

            var parser = new TacoParser();

            var locations = lines.Select(parser.Parse).ToArray();

            ITrackable bell1 = null;
            ITrackable bell2 = null;

            double distance = 0;

            foreach (var locA in locations)
            {
                GeoCoordinate corA = new GeoCoordinate(locA.Location.Latitude, locA.Location.Longitude);
                foreach (var locB in locations)
                {
                    GeoCoordinate corB = new GeoCoordinate(locB.Location.Latitude, locB.Location.Longitude);
                    var maxDistance = corA.GetDistanceTo(corB) / 1000;
                    if (maxDistance > distance)
                    {
                        distance = maxDistance;
                        bell1 = locA;
                        bell2 = locB;
                    }
                }
            }
            Console.WriteLine($"The furthest distance is between locations: {bell1.Name} and {bell2.Name} at {distance}km");
        }
    }
}
