
class Program
{
    static void Main()
    {
      
        string spravneJmeno = "HlavniUcet";
        string spravneHeslo = "6767667";

        string login;
        string heslo;
        string message = " Přihlášení proběhlo úspěšně.";


        Console.Write("Zadej uživatelské jméno: ");
        login = Console.ReadLine();

        Console.Write("Zadej heslo: ");
        heslo = Console.ReadLine();


        if (login == spravneJmeno && heslo == spravneHeslo)
        {

            Console.WriteLine(message);
        }
        else
        {
           
            Console.WriteLine("Chyba: Špatné jméno nebo heslo!");
        }
    }
}


