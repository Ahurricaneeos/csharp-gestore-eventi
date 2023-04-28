using csharp_gestore_eventi;

/* Console.Write("Inserisci il nome dell'evento: ");
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
} */

Console.Write("Inserisci titolo del tuo programma: ");
string programTitle = Console.ReadLine();


ProgrammaEventi programma = new ProgrammaEventi(programTitle);

Console.WriteLine("Indica il numero di eventi da inserire: ");
int userNumberOfEvents = int.Parse(Console.ReadLine());

for  (int i = 0; i < userNumberOfEvents; i++)
{
    try
    {
        Console.Write("Inserisci il nome del " + (i + 1) + " evento: ");
        string eventTitle = Console.ReadLine();
        Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il numero di posti totali: ");
        int capacity = int.Parse(Console.ReadLine());
        int places = 0;
        Evento evento = new Evento(eventTitle, date, capacity, places);
        programma.AddEvents(evento);
    } catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.Write("Il numero di eventi nel programma è: ");
Console.WriteLine("Ecco il tuo programma eventi: ");
Console.WriteLine(programma.ToString());
