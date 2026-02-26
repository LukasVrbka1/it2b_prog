using System;

class Program
{
    static bool LzeSestrojitTrojuhelnik(double a, double b, double c)
    {

        return a + b > c && a + c > b && b + c > a;
    }

    static void Main()
    {
        Console.Write("Zadejte délku první strany: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Zadejte délku druhé strany: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Zadejte délku třetí strany: ");
        double c = double.Parse(Console.ReadLine());

        if (LzeSestrojitTrojuhelnik(a, b, c))
        {
            Console.WriteLine("ano lze sestrojit trojuhelnik");
        }
        else
        {
            Console.WriteLine("ne nelze sestrojit trojuhelnik");
        }
    }
}


       
      
 