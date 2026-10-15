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


bool alive = HP > 0;
bool doingOk = HP > 20;
bool isRich = GOLD >= 100;
bool isReady = alive && maMape && doingOk;


//
Console.ForegroundColor = ConsoleColor.Blue;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("+======================================+");
Console.WriteLine("\t\tKARTA BOHATERA\t\t");
Console.WriteLine("+======================================+");
Console.WriteLine($"Imię:\t\t{imie}");
Console.WriteLine($"LVL:\t\t{LVL}");
Console.WriteLine($"HP:\t\t{HP}/100");
Console.WriteLine($"ATK:\t\t{ATK}");
Console.WriteLine("+--------------------------------------+");
Console.WriteLine("\t\tEKWIPUNEK\t\t");
Console.WriteLine("+--------------------------------------+");
Console.WriteLine($"Złoto:\t\t{GOLD}");
Console.WriteLine($"Mikstury: {MIX}");
if (maMape)
{
  Console.WriteLine($"Mapa: 1");  
}

Console.WriteLine("+======================================+");
Console.ResetColor();