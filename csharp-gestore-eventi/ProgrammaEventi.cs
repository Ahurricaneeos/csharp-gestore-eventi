using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class ProgrammaEventi
    {
        string title;
        List<Evento> events = new List<Evento>();

        ProgrammaEventi(string title, List<Evento> events)
        {
            this.title = title;
            this.events = events;
        }

        public string GetTitle() { return title; }
        public List<Evento> GetEvents() { return events; }

        public void SetTitle(string title) { this.title = title; }
        public void SetEvent(List<Evento> events) { this.events = events; }

        public void AddEvents(Evento addedEvent)
        {
            events.Add(addedEvent);
        }

        public void DateOfEvents(DateTime dateEvent) 
        {
            foreach (Evento events in events)
            if (dateEvent == events.GetDate())
            {
                Console.WriteLine(events);
            }
        }

        public static void StampEventList(List<Evento> events)
        {
            foreach (Evento addedEvents in events)
            Console.WriteLine(events);
        }

        public void DeleteEvents(List<Evento> events)
        {
            events.Clear();
        }

        public int ListLenght(List<Evento> events)
        {
            return events.Count();
        }
        public override string ToString()
        {
            string stamp = title + "\n";
            foreach (Evento events in events)
            {
                stamp = stamp + "\t" + events.ToString() + "\n";
            }
            return stamp;
        }
    }
}
