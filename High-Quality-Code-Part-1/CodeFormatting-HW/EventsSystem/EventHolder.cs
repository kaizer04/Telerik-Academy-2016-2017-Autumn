namespace EventsSystem
{
    using System;

    using Wintellect.PowerCollections;

    public class EventHolder
    {
        public EventHolder()
        {
            this.Messages = new Messages();
            this.EventsListByTitle = new MultiDictionary<string, Event>(true);
            this.EventsListbyDate = new OrderedBag<Event>();
        }

        public Messages Messages { get; set; }

        public MultiDictionary<string, Event> EventsListByTitle { get; set; }

        public OrderedBag<Event> EventsListbyDate { get; set; }

        public void AddEvent(DateTime date, string title, string location)
        {
            var newEvent = new Event(date, title, location);

            this.EventsListByTitle.Add(title.ToLower(), newEvent);

            this.EventsListbyDate.Add(newEvent);

            this.Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();

            int removed = 0;

            foreach (var eventToRemove in this.EventsListByTitle[title])
            {
                removed++;
                this.EventsListbyDate.Remove(eventToRemove);
            }

            this.EventsListByTitle.Remove(title);

            this.Messages.EventDeleted(removed);
        }
        
        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = this.EventsListbyDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);

            int showed = 0;

            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                this.Messages.PrintEvent(eventToShow);

                showed++;
            }

            if (showed == 0)
            {
                this.Messages.NoEventsFound();
            }
        }
    }
}