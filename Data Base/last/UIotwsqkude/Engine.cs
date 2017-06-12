using System;

namespace UIotwsqkude
{
    internal class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
       // private IParser parser;

        public Engine(IReader readerProvider, IWriter writerProvider//, IParser parserProvider
            )
        {
            if (readerProvider == null)
            {
                throw new ArgumentNullException("no Reader");
            }

            if (writerProvider == null)
            {
                throw new ArgumentNullException("Writer");
            }

           // if (parserProvider == null)
            {
             //   throw new ArgumentNullException("parser");
            }

            this.reader = readerProvider;
            this.writer = writerProvider;
          //  this.parser = parserProvider;
        
    }
        public void Log()
        {
            Console.WriteLine("Logged");
        }

        public string ReadLine()
        {
            return reader.ReadLine();
        }

        public void Start()
        {
            writer.WriteLine("Enter command whatever string value and enter ");
            string commandAsString = reader.ReadLine();
            writer.WriteLine(commandAsString);
            

        }
        
      

       // public void WriteLine()
      //  {
       //     writer.WriteLine();
      //  }

        public void WriteLine(string input)
        {
            writer.WriteLine(input);
        }
    }
}