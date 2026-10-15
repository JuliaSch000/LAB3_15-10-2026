Console.WriteLine("HP?");
int HP = int.Parse(Console.ReadLine()!);
Console.WriteLine("Obrażenia broni?");
int ATK = int.Parse(Console.ReadLine()!);
Console.WriteLine("Czy masz miksturę?");
bool maMiksture = bool.Parse(Console.ReadLine()!);

//

bool dead = HP <= 0;


//

Console.WriteLine("Wybierz akcję:");
Console.WriteLine("1 - ATAK");
Console.WriteLine("2 - LECZENIE");
Console.WriteLine("3 - UCIECZKA");
int akcja = int.Parse(Console.ReadLine()!);

//

if (dead)
{
   Console.WriteLine("PRZEGRANA!\nSkończyły ci się punkty zdrowia!"); 
}
else
{
    switch (akcja)
{
    case 1:
    if ((HP > 0) && (HP <= 20))
{
    Console.WriteLine("UWAGA! NISKIE HP!");
}
    if (ATK <= 0)
            {
                Console.WriteLine("O nie! Przeciwnik nie otrzymał obrażeń!");
            }
    else
            {
                Console.WriteLine($"Wykonaleś atak!\nPrzeciwnik traci {ATK} HP!");
            }
    
    break;

    case 2:
    if (maMiksture)
    {
        Console.WriteLine("Używasz mikstury! Twoje HP jest teraz pełne.");
    }
    else
    if ((HP > 0) && (HP <= 20))
{
    Console.WriteLine("UWAGA! NISKIE HP!");
}
    {
         Console.WriteLine("O nie! Nie masz mikstury!");
    }
    break;

    case 3:
    Console.WriteLine("Udało ci się uciec z walki.");
    break;

    default:
    Console.WriteLine("Nieznana akcja.");
    break;

}
}
