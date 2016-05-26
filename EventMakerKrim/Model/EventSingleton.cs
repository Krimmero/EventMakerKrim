using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventMakerKrim.Model
{
    class EventSingleton
    {
        private static EventSingleton instance;

        private EventSingleton()
        {
            Events = new ObservableCollection<Event>();
            Events.Add(new Event(1, "Kim", "Supermand", "Undløse", DateTime.Now));
            Events.Add(new Event(2, "Tine", "Wonderwoman", "Undløse", DateTime.Now));
        }

        public static EventSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EventSingleton();
                }
                return instance;
            }
        }

        public ObservableCollection<Event> Events { get; set; }

     

        public void AddEvent(Event newEvent)
        {
            Events.Add(newEvent);
        }

        public void AddEvent(int id, string name, string description, string place, DateTime dateTime)
        {
            Events.Add(new Event(id, name, description, place, dateTime));
           
        }
    }
}
