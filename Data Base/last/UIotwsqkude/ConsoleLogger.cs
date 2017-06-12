using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UIotwsqkude
{
    class ConsoleLogger:ILogger
    {
        private ICommandQuery command;
        private IDateTime currDateTime;

        public ConsoleLogger(ICommandQuery cmd, IDateTime dateTime)
        {
            command = cmd;
            currDateTime = dateTime;
        }
        public void Log()
        {
            Console.WriteLine(currDateTime.Time.ToString("yyyy-MM-dd"));
            Console.WriteLine(command.CommandAsString);
        }

        
    }
}
