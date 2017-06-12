namespace FluentApiTester
{
   public class Publisher
    {
       public Publisher(string name)
       {
           Name = name;
       }
        public string  Name { get; set; }
        public int Id { get; set;}
        public virtual PublisherAddress Address { get; set; }
        
    }
}
