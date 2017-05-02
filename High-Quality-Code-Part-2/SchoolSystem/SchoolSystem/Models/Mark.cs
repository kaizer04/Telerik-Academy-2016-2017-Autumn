namespace SchoolSystem.Models
{
    public class Mark
    {
        public float value;
        internal Subject subject;

        public Mark(Subject subject, float value)
        {
            this.subject = subject;
            this.value = value;
        }
    }
}
