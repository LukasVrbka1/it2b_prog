
class Program
{
    static void Smazat(List<int> cisla, int hodnota)
    {
        while (cisla.Contains(hodnota))
        {
            cisla.Remove(hodnota);
        }
    }

    static void Main()
    {
        List<int> mujList = new List<int> { 1, 5, 3, 5, 2, 5, 8 };
        int hledane = 5;

        Smazat(mujList, hledane);

        foreach (int cislo in mujList)
        {
            Console.WriteLine(cislo);
        }
    }
}
