using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testnis
{
    public interface IEventRepository
    {
        int Count { get; }
        void AddEvent(Event newEvent);
        void DeleteEvent(int id);
        void UpdateEvent(int id, Event newEvent);
        List<Event> GetAllEvents();
        Event GetEventById(int id);
    }
}
