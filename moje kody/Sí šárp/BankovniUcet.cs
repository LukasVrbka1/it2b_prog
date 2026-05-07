public class BankovniUcet
{
    public string Majitel;
    private double Zustatek;
    private List<string> Historie;
    public double UrokovaSazba;

    public BankovniUcet(string jmeno, double vklad, double urok)
    {
        Majitel = jmeno;
        Zustatek = vklad;
        UrokovaSazba = urok;
        Historie = new List<string>();
        Historie.Add("Účet založen s vkladem: " + vklad);
    }

    public void VlozitPeníze(double castka)
    {
        if (castka > 0)
        {
            Zustatek = Zustatek + castka;
            Historie.Add("Vloženo: " + castka);
        }
    }

    public void VybratPeníze(double castka)
    {
        if (castka > 0 && castka <= Zustatek)
        {
            Zustatek = Zustatek - castka;
            Historie.Add("Vybráno: " + castka);
        }
        else
        {
            Console.WriteLine("Nemáš dost peněz!");
        }
    }

    public void PridejUrok()
    {
        double urok = Zustatek * UrokovaSazba;
        Zustatek = Zustatek + urok;
        Historie.Add("Připsán úrok: " + urok);
    }

    public void UkazVsechno()
    {
        Console.WriteLine("Majitel: " + Majitel);
        Console.WriteLine("Aktuální stav: " + Zustatek + " Kč");
        Console.WriteLine("Historie:");
        foreach (string zaznam in Historie)
        {
            Console.WriteLine("- " + zaznam);
        }
    }
}