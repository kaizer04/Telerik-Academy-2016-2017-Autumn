namespace UIotwsqkude
{
    internal interface ICommandQuery
    {
       string  CommandAsString { get; }
        void Process(string command);
    }
}