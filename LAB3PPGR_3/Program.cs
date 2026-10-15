Console.WriteLine("Podaj swój wiek:");
int wiek = int.Parse(Console.ReadLine()!);

if (wiek < 0)
{
    Console.WriteLine("Niepoprawny wiek.");
}
else
{
    if (wiek <= 12)
{
    Console.WriteLine("Jesteś dzieckiem.");
}
    else if ((13 <= wiek) && (wiek <= 17))
    {
        Console.WriteLine("Jesteś nastolatkiem.");
    }
    else if ((18 <= wiek) && (wiek <= 64))
    {
        Console.WriteLine("Jesteś dorosły.");
    }
    else if ((65 <= wiek) && (wiek <= 122))
    {
        Console.WriteLine("Jesteś seniorem.");
    }
     else if (wiek > 122)
    {
        Console.WriteLine("Ok no nie przesadzaj");
    }
}