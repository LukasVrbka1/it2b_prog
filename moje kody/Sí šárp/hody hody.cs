

class Program
{
    static void Main()
    {
        
        List<char> vysluzka = new List<char>();

        bool pokracovat = true; 
        int volba;

        while (pokracovat)
        {
            Console.WriteLine("\n--- Velikonoční košík ---");
            Console.WriteLine("1) Přidej vajíčko (r, g, b)");
            Console.WriteLine("2) Vypiš sebraná vajíčka");
            Console.WriteLine("3) Vypiš počet vajec");
            Console.WriteLine("0) Ukončit koledování");
            Console.Write("Vyber akci: ");

          
            if (!int.TryParse(Console.ReadLine(), out volba))
            {
                Console.WriteLine("Zadej prosím číslo!");
                continue;
            }

            if (volba == 0)
            {
                pokracovat = false;
                Console.WriteLine("Koleda skončila. Máš bohatou výslužku!");
            }
            else if (volba == 1)
            {
                Console.Write("Zadej barvu vajíčka (r = red, g = green, b = blue): ");
                string vstup = Console.ReadLine().ToLower();

                if (string.IsNullOrEmpty(vstup) || !"rgb".Contains(vstup[0]))
                {
                    Console.WriteLine("Neplatná barva! Máme jen červená (r), zelená (g) a modrá (b).");
                }
                else
                {
                    vysluzka.Add(vstup[0]);
                    Console.WriteLine($"Vajíčko '{vstup[0]}' bylo přidáno do košíku.");
                }
            }
            else if (volba == 2)
            {
                if (vysluzka.Count == 0)
                {
                    Console.WriteLine("Košík je zatím prázdný.");
                }
                else
                {
                    Console.WriteLine("Obsah košíku: " + string.Join(", ", vysluzka));
                }
            }
            else if (volba == 3)
            {
                Console.WriteLine($"V košíku máš celkem {vysluzka.Count} vajec.");
            }
            else
            {
                Console.WriteLine("Neplatná operace, zkus to znovu.");
            }
        }
    }
}
