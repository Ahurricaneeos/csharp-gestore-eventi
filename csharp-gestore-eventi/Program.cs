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