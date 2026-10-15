Console.WriteLine("Imię?");
string imie = Console.ReadLine()!;
Console.WriteLine("ATK?");
int ATK = int.Parse(Console.ReadLine()!);
Console.WriteLine("HP? (MAX: 100)");
int HP = int.Parse(Console.ReadLine()!);
if (HP > 100)
{
    HP = 100;
}
Console.WriteLine("LVL?");
int LVL = int.Parse(Console.ReadLine()!);
Console.WriteLine("Złoto?");
int GOLD = int.Parse(Console.ReadLine()!);
Console.WriteLine("Liczba mikstur?");
int MIX = int.Parse(Console.ReadLine()!);
Console.WriteLine("Czy masz mapę?");
bool maMape = bool.Parse(Console.ReadLine()!);
Console.WriteLine("Czy masz kompas?");
bool maKompas = bool.Parse(Console.ReadLine()!);


bool alive = HP > 0;
bool doingOk = HP > 25;
bool isRich = GOLD >= 100;
bool isReady = alive && (maMape || maKompas) && doingOk;
string stan = HP == 100 ? "Masz pełne HP" : "Potrzebujesz leczenia";

//

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("+======================================+");
Console.WriteLine("\t\tKARTA BOHATERA\t\t");
Console.WriteLine("+======================================+");
Console.WriteLine($"Imię:\t\t{imie}");
Console.WriteLine($"LVL:\t\t{LVL}");
Console.WriteLine($"HP:\t\t{HP}/100 ({stan}!)");
Console.WriteLine($"ATK:\t\t{ATK}");
Console.WriteLine("+--------------------------------------+");
Console.WriteLine("\t\tEKWIPUNEK\t\t");
Console.WriteLine("+--------------------------------------+");
Console.WriteLine($"Złoto:\t\t{GOLD}");
Console.WriteLine($"Mikstury:\t{MIX}");
if (maMape)
{
  Console.WriteLine($"Mapa:\t1");  
}

Console.WriteLine("+======================================+\n\n");
Console.ResetColor();

// Wiem o funkcji \n. Osobne console.writeline-y są dla mnie bardziej czytelne

if (isReady)
{
  Console.WriteLine("Jesteś gotowy do podróży!");
  Console.WriteLine("Po długiej wyprawie docierasz do zamku.");
  Console.WriteLine("Możesz wejść na trzy sposoby:");
  Console.WriteLine("1 - PRZEZ WROTA");
  Console.WriteLine("2 - PRZEZ OKNO");
  Console.WriteLine("3 - WYKOPAĆ TUNEL DO SKARBCA");
  Console.WriteLine("Którą drogę wybierzesz?");
  int droga = int.Parse(Console.ReadLine()!);

  switch (droga)
  {
    case 1:
    Console.WriteLine("Po drugiej stronie czekają na ciebie potwory!");
    Console.WriteLine("Mają one o wiele wyższy poziom niż ty!");
    Console.WriteLine("Potwory jednak nie atakują, tylko proszą o 100 G za wstęp.");
    if (isRich)
      {
        Console.WriteLine("Jesteś bogaty, więc płacisz im 100 G.");
        Console.WriteLine("Nagle... wrota zamykają się za tobą! To była pułapka!");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\tKONIEC GRY\t\t");
        Console.ResetColor();
      }
    else
      {
        Console.WriteLine("Nie masz tyle złota, więc wracasz do domu.");
        Console.WriteLine("Po drodze znajdujesz jednak skrzynię ze skarbami!");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\t\tWYGRANA\t\t");
        Console.ResetColor();
      }
      break;
    
    case 2:
    if (MIX > 0)
      {
        Console.WriteLine("Używasz mikstury, by unieść się na wysokość okna.");
        Console.WriteLine("Docierasz do skarbca!");
         Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\t\tWYGRANA\t\t");
        Console.ResetColor();
      }
    else
      {
        Console.WriteLine("Nie jesteś w stanie dosięgnąć do okien!");
        Console.WriteLine("Wracasz do domu.");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\tKONIEC GRY\t\t");
        Console.ResetColor();
      }
      break;
    case 3:
    Console.WriteLine("Kopiesz dłuuuugi tunel. Docierasz do skarbca.");
     Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\t\tWYGRANA\t\t");
        Console.ResetColor();
        break;
      default:
      Console.WriteLine("Nieznana akcja. Wracasz do domu.");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\tKONIEC GRY\t\t");
        Console.ResetColor();
        break;
  }

}
else
{
  Console.WriteLine("Nie jesteś gotowy do podróży :(");
    Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\tKONIEC GRY\t\t");
        Console.ResetColor();
}