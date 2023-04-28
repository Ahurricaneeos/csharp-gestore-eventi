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

        public ProgrammaEventi(string title, List<Evento> events)
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
            foreach (Evento events in events)
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

        public string ListToString()
        {
            string str = title;
            foreach (Evento events in events)
            {
                str = str + "-" + events.ToString();
            }
            return str;
        }
    }
}

