using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Evento
    {
        public string title;
        public DateTime date;
        public int capacity;
        public int places;

        public Evento (string title, DateTime date, int capacity, int places)
        {
            SetTitle(title);
            SetDate(date);
            SetCapacity(capacity);
            this.places = 0;
        }
          
        public string GetTitle() { return title; }
        public DateTime GetDate() { return date; }
        public int GetCapacity() { return capacity; }
        public int GetPlaces() { return places;}

        private void SetTitle(string title)
        {
            if (title == "")
            { throw new Exception("Il campo titolo è vuoto"); }
            this.title = title;
        }
        private void SetDate(DateTime date)
        {
            if (date < DateTime.Now)
            { throw new Exception("La data inserita è passata"); }
            this.date = date;
        }
        private void SetCapacity(int capacity)
        {
            if (capacity < 0)
            { throw new Exception("La capacità inserita è un numero negativo"); }
            this.capacity = capacity;
        }
    }
}
