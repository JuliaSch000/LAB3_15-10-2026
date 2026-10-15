Console.WriteLine("Ile masz punktów życia?");
int HP = int.Parse(Console.ReadLine()!);
Console.WriteLine("Czy masz klucz?");
bool hasKey = bool.Parse(Console.ReadLine()!);
Console.WriteLine("Czy znasz hasło do lochu?");
bool knowsPassword = bool.Parse(Console.ReadLine()!);


bool dead = HP <= 0;


if (dead)
{
    Console.WriteLine("Nie możesz wejść do lochu, ponieważ nie żyjesz.");
}

else if (!dead && hasKey || knowsPassword)
{
    Console.WriteLine("Możesz wejść do lochu!");
}
else
{
Console.WriteLine("Nie jesteś w stanie wejść do lochu.");
}