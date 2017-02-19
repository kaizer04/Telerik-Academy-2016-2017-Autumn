namespace EventsSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Wintellect.PowerCollections;

    public class EventHolder
    {
        MultiDictionary<string, Event> eventsListByTitle = new MultiDictionary<string, Event>(true);
        OrderedBag<Event> eventsListbyDate = new OrderedBag<Event>();

        public void AddEvent(DateTime date, string title, string location)
        {
            var newEvent = new Event(date, title, location);

            eventsListByTitle.Add(title.ToLower(), newEvent);

            eventsListbyDate.Add(newEvent);

            Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();

            int removed = 0;

            foreach (var eventToRemove in eventsListByTitle[title])
            {
                removed++;
                eventsListbyDate.Remove(eventToRemove);
            }

            eventsListByTitle.Remove(title);

            Messages.EventDeleted(removed);
        }
        
        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = eventsListbyDate.RangeFrom(new Event(date, "", ""), true);

            int showed = 0;

            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);

                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}
