using csharp_gestore_eventi;

Console.Write("Inserisci il nome dell'evento: ");
string title = Console.ReadLine();
Console.Write("Inserisci la data dell'evento: ");
DateTime date = DateTime.Parse(Console.ReadLine());
Console.Write("Inserisci il numero di posti totali: ");
int places = int.Parse(Console.ReadLine());
Console.Write("Quanti posti desideri prenotare? ");
int reservedPlaces  = int.Parse(Console.ReadLine());

Evento evento1 = new Evento(title, date, places, reservedPlaces);
Console.WriteLine();
Console.WriteLine("Numero posti prenotati: " + evento1.GetPlaces());
int availablePlaces = places - reservedPlaces;
Console.WriteLine("Numero posti disponibili: " + availablePlaces);

bool wantCancelPlaces  = false;
while (wantCancelPlaces == false)
{
    Console.WriteLine("Vuoi disdire dei posti? y/n");
    string userInputYN = Console.ReadLine();
    if (userInputYN == "n")
    {
        Console.WriteLine("Ok va bene!");
        wantCancelPlaces = true;
    }
    else
    {
        Console.WriteLine("Indica il numero di posti da disdire: ");
        int cancelledPlaces = int.Parse(Console.ReadLine());
        evento1.CancelPlaces(cancelledPlaces);
        reservedPlaces = reservedPlaces - cancelledPlaces;
        availablePlaces = availablePlaces + cancelledPlaces;
    }
    Console.WriteLine("Numero di posti prenotati: " + reservedPlaces);
    Console.WriteLine("Numero di posti disponibili: " + availablePlaces);
}

evento1.ToString();