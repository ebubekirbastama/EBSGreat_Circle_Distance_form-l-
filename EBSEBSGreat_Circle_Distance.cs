using System;

class Program
{
    static void Main(string[] args)
    {
        double lat1 = 39.9333635;
        double lon1 = 32.8597419;
        double lat2 = 43.9333635;
        double lon2 = 32.8597419;

        double dLat = DegreesToRadians(lat2 - lat1);
        double dLon = DegreesToRadians(lon2 - lon1);
        lat1 = DegreesToRadians(lat1);
        lat2 = DegreesToRadians(lat2);

        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                  Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        double distance = 6371 * c;

        Console.WriteLine("The great circle distance is " + distance + " km.");
    }

    static double DegreesToRadians(double degrees)
    {
        return degrees * Math.PI / 180;
    }
}
