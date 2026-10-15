Console.WriteLine("Podaj kierunek wyprawy:");
string kierunek = Console.ReadLine()!;

switch (kierunek)
{
    case "Północ":
    case "północ":
    case "Polnoc":
    case "polnoc":
    case "N":
    Console.WriteLine("Dotarłeś do wielkiej góry !!!");
    break;
    
    case "Wschód":
    case "wschód":
    case "Wschod":
    case "wschod":
    case "E":
    Console.WriteLine("Dotarłeś do jeziora");
    break;
    
    case "Południe":
    case "południe":
    case "Poludnie":
    case "poludnie":
    case "S":
    Console.WriteLine("Dotarłeś do jaskini.........");
    break;

    case "Zachód":
    case "zachód":
    case "Zachod":
    case "zachod":
    case "W":
    Console.WriteLine("Dotarłeś do skarbca?!?!?!");
    break;

    default:
    Console.WriteLine("Niepoprawny kierunek :(");
    break;



}