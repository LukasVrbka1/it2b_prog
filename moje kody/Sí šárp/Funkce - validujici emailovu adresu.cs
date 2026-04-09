using System;

class Program
{
    static void Main()
    {
        string vstup = "st026569@student.cichnovabrno.cz";
        int platne = (vstup);

        if (platne == 1)
        {
            Console.WriteLine("Email je v poradku");
        }
        else
        {
            Console.WriteLine("Email je neplatny");
        }
    }

    static int  (string email)
    {
        char[] znaky = email.ToCharArray();
        int delka = znaky.Length;
        int pocetZavinacu = 0;
        int poziceZavinace = -1;

        for (int i = 0; i < delka; i++)
        {
            if (znaky[i] == '@')
            {
                pocetZavinacu++;
                poziceZavinace = i;
            }
        }

        if (pocetZavinacu != 1)
        {
            return 0;
        }

        if (poziceZavinace == 0)
        {
            return 0;
        }

        int teckaNalezena = 0;
        for (int j = poziceZavinace + 1; j < delka; j++)
        {
            if (znaky[j] == '.')
            {
                teckaNalezena = 1;
            }
        }

        if (teckaNalezena == 1)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}