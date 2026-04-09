using System;

class Program
{
    static void Main()
    {
        int hlasX, hlasY;
        double celkovyHlas, procentaX, procentaY;

        Console.Write("Zadejte počet hlasů pro kandidáta X: ");
        hlasX = int.Parse(Console.ReadLine());

        Console.Write("Zadejte počet hlasů pro kandidáta Y: ");
        hlasY = int.Parse(Console.ReadLine());

        celkovyHlas = hlasX + hlasY;
        procentaX = (double)hlasX / celkovyHlas * 100;
        procentaY = (double)hlasY / celkovyHlas * 100;

        Console.WriteLine($"Kandidát X získal {procentaX:} hlasů.");
        Console.WriteLine($"Kandidát Y získal {procentaY:} hlasů.");
    }
}