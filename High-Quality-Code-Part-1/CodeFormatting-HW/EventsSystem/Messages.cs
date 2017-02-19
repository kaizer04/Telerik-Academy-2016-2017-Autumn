namespace EventsSystem
{
    using System.Text;

    public class Messages
    {
        public Messages()
        {
            this.Output = new StringBuilder();
        }

        public StringBuilder Output { get; set; }

        public void EventAdded()
        {
            this.Output.Append("Event added\n");
        }

        public void EventDeleted(int x)
        {
            if (x == 0)
            {
                this.NoEventsFound();
            }
            else
            {
                this.Output.AppendFormat("{0} events deleted\n", x);
            }
        }

        public void NoEventsFound()
        {
            this.Output.Append("No events found\n");
        }

        public void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                this.Output.Append(eventToPrint + "\n");
            }
        }
    }
}