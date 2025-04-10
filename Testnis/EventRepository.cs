using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testnis
{
    public class EventRepository : IEventRepository
    {
        private List<Event> _events;
        public int Count { get { return _events.Count; } }

        public EventRepository()
        {
            _events = new List<Event>();
        }
        public void AddEvent(Event newEvent)
        {
            if (!_events.Contains(newEvent))
            {
                _events.Add(newEvent);
            }
        }

        public void DeleteEvent(int id)
        {
            _events.Remove(GetEventById(id));
        }

        public List<Event> GetAllEvents()
        {
            return _events;
        }

        public Event GetEventById(int id)
        {
            Event foundEvent = null;
            foreach (Event eventItem in _events)
            {
                if (eventItem.EventId == id)
                {
                    foundEvent = eventItem;
                }
            }
            return foundEvent;
        }

        public void UpdateEvent(int id, Event newEvent)
        {
            Event foundEvent = GetEventById(id);
            if (_events.Contains(foundEvent))
            {
                if (id == newEvent.EventId)
                {
                    DeleteEvent(id);
                    AddEvent(newEvent);
                }
            }
        }
    }
}
