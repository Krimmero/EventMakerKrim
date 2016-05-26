using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EventMakerKrim.Annotations;
using EventMakerKrim.Common;
using EventMakerKrim.Handler;
using EventMakerKrim.Model;

namespace EventMakerKrim.ViewModel
{
    class EventViewModel:INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private string _description;
        private string _place;
        private DateTimeOffset _date;
        private TimeSpan _time;
        public int Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(); }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged(); }
        }

        public string Place
        {
            get {return _place; }
            set { _place = value; OnPropertyChanged(); }
        }

        public DateTimeOffset Date
        {
            get { return _date; }
            set { _date = value; OnPropertyChanged(); }
        }

        public TimeSpan Time
        {
            get { return _time; }
            set { _time = value; OnPropertyChanged(); }
        }
        public EventSingleton EventSingleton { get; set; }

        public EventViewModel()
        {
            EventSingleton = EventSingleton.Instance;
            DateTime dt = System.DateTime.Now;
            _date = new DateTimeOffset(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0, new TimeSpan());
            _time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

            EventHandler = new Handler.EventHandler(this);

            _createEventCommand = new RelayCommand(EventHandler.CreateEvent);
        }

        private ICommand _createEventCommand;

        public ICommand CreateEventCommand
        {
            get { return _createEventCommand; }
            set { _createEventCommand = value; }
        }

        public Handler.EventHandler EventHandler { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
