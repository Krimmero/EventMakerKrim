using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMakerKrim.Converter;
using EventMakerKrim.Model;
using EventMakerKrim.ViewModel;

namespace EventMakerKrim.Handler
{
    class EventHandler
    {
        public EventViewModel EventViewModel { get; set; }

        public EventHandler(EventViewModel eventViewModel)
        {
            EventViewModel = eventViewModel;
        }

        public void CreateEvent()
        {
            EventViewModel.EventSingleton.AddEvent(EventViewModel.Id, EventViewModel.Name, EventViewModel.Place,
                EventViewModel.Description, DateTimeConverter.DateTimeOffsetAndTimeSetToDateTime(EventViewModel.Date, EventViewModel.Time));

        }
    }
}
