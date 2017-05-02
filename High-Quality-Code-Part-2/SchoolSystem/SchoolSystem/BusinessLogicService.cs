namespace SchoolSystem
{
    // I am not sure if we need this, but too scared to delete.
    public class BusinessLogicService
    {
        public void Execute(string input)
        {
            var engine = new Engine(input);

            engine.Reader();
        }
    }
}