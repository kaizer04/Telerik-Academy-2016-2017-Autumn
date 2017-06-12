using System.Data;

namespace UIotwsqkude
{
    internal interface IEngine:ILogger,IReader,IWriter
    {
        void Start();
    }
}