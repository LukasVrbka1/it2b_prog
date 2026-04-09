
class Program
{
    static void Main()
    {
        List<string> nazvy = new List<string>();
        List<int> hodnoceni = new List<int>();
        List<int> roky = new List<int>();

        bool jedeme = true;

        while (jedeme)
        {
            Console.WriteLine("\n1-Pridat, 2-Rok, 3-Hledat, 4-Prumer, 5-Smazat, 0-Konec");
            string volba = Console.ReadLine();

            if (volba == "1")
            {
                Console.Write("Nazev: ");
                nazvy.Add(Console.ReadLine());
                Console.Write("Hodnoceni (0-100): ");
                hodnoceni.Add(int.Parse(Console.ReadLine()));
                Console.Write("Rok: ");
                roky.Add(int.Parse(Console.ReadLine()));
            }
            else if (volba == "2")
            {
                Console.Write("Zadej rok: ");
                int r = int.Parse(Console.ReadLine());
                for (int i = 0; i < nazvy.Count; i++)
                {
                    if (roky[i] == r) Console.WriteLine(nazvy[i]);
                }
            }
            else if (volba == "3")
            {
                Console.Write("Hledej text: ");
                string text = Console.ReadLine();
                for (int i = 0; i < nazvy.Count; i++)
                {
                    if (nazvy[i].Contains(text)) Console.WriteLine(nazvy[i]);
                }
            }
            else if (volba == "4")
            {
                if (hodnoceni.Count > 0) Console.WriteLine("Prumer: " + hodnoceni.Average());
            }
            else if (volba == "5")
            {
                Console.Write("Smazat film: ");
                string smazat = Console.ReadLine();
                int index = nazvy.IndexOf(smazat);
                if (index != -1)
                {
                    nazvy.RemoveAt(index);
                    hodnoceni.RemoveAt(index);
                    roky.RemoveAt(index);
                }
            }
            else if (volba == "0")
            {
                jedeme = false;
            }
        }
    }
}