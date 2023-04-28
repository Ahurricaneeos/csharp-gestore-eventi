using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class ProgrammaEventi
    {
        public string title;
        public List<Evento> events;

        public ProgrammaEventi(string title)
        {
            this.title = title;
            events = new List<Evento>();
        }

        public string GetTitle() { return title; }
        public List<Evento> GetEvents() { return events; }

        public void SetTitle(string title) { this.title = title; }
        public void SetEvent(List<Evento> events) { this.events = events; }

        public void AddEvents(Evento addedevents)
        {
            events.Add(addedevents);
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

        public static void DeleteEvents(List<Evento> events)
        {
            events.Clear();
        }

        public static int ListLenght(List<Evento> events)
        {
            return events.Count;
        }

        public override string ToString()
        {
            string str = title;
            foreach (Evento listevents in events)
            {
                str = str + "-" + events.ToString();
            }
            return str;
        }
    }
}

