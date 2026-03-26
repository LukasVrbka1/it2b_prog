using System;

class Program
{
    static void Main()
    {
        string text = "Ahoj, jak se MAS?";
        char[] pole = text.ToCharArray();
        
        int male = 0;
        int velke = 0;

        for (int i = 0; i < pole.Length; i++)
        {
            if (pole[i] >= 'A' && pole[i] <= 'Z')
            {
                velke++;
            }
            else if (pole[i] >= 'a' && pole[i] <= 'z')
            {
                male++;
            }
        }

        if (male > velke)
        {
            Console.WriteLine("Vice je malych");
        }
        else if (velke > male)
        {
            Console.WriteLine("Vice je velkych");
        }
        else
        {
            Console.WriteLine("Je jich stejne");
        }
    }
}