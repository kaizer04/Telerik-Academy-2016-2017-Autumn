namespace EventsSystem
{
    using System;

    public class CommandFactory
    {
        public CommandFactory()
        {
            this.Events = new EventHolder();
        }

        public EventHolder Events { get; set; }

        public bool ExecuteNextCommand(string command)
        {
            if (command[0] == 'A')
            {
                this.AddEvent(command);

                return true;
            }

            if (command[0] == 'D')
            {
                this.DeleteEvents(command);

                return true;
            }
            
            if (command[0] == 'L')
            {
                this.ListEvents(command);

                return true;
            }

            if (command[0] == 'E')
            {
                return false;
            }

            return true;
        }

        private void ListEvents(string command)
        {
            int pipeIndex = command.IndexOf('|');

            var date = this.GetDate(command, "ListEvents");

            string countString = command.Substring(pipeIndex + 1);

            int count = int.Parse(countString);
            
            this.Events.ListEvents(date, count);
        }

        private void DeleteEvents(string command)
        {
            string title = command.Substring("DeleteEvents".Length + 1);

            this.Events.DeleteEvents(title);
        }

        private void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;

            this.GetParameters(command, "AddEvent", out date, out title, out location);

            this.Events.AddEvent(date, title, location);
        }

        private void GetParameters(string commandForExecution, string commandType, out DateTime dateAndTime, out string eventTitle, out string eventLocation)
        {
            dateAndTime = this.GetDate(commandForExecution, commandType);
            int firstPipeIndex = commandForExecution.IndexOf('|');
            int lastPipeIndex = commandForExecution.LastIndexOf('|');

            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
                eventLocation = string.Empty;
            }
            else
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        private DateTime GetDate(string command, string commandType)
        {
            var date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));

            return date;
        }
    }
}
