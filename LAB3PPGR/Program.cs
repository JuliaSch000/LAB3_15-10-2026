Console.WriteLine("Podaj liczbę:");
int liczba = int.Parse(Console.ReadLine()!);

int checkParzysta = liczba % 2;

if (checkParzysta < 0)
{
    checkParzysta *= -1;
}

if (liczba == 0)
{
    Console.WriteLine("Podałeś 0.");
}

else

{
 if (checkParzysta <= 0)
{
    Console.WriteLine("Liczba jest parzysta");
}   
else
{
        Console.WriteLine("Liczba jest nieparzysta");
    }
}

