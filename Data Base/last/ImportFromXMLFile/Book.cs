namespace ImportFromXMLFile
{
    public class Book
    {
       private string authorName;
       private string title;

        public Book(string authorname, string t)
        {
            authorName = authorname;
            title = t;
        }

       
        public string Authorname 
        {
            get
            {
                return authorName;
            }
            set
            {
                authorName = value;
            }
        }

        public string Title
        {
            get { return title; }
            set { title = value;}
        }
    }


}
