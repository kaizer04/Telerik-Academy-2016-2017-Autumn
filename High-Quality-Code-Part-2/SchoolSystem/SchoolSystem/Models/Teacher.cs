namespace SchoolSystem.Models
{
    public class Teacher
    {
        public string firstName;
        public string lastName;
        public Subject subject;

        public Teacher(string firstName, string lastName, Subject subject)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.subject = subject;
        }

        public void AddMark(Student student, float value)
        {
            var mark = new Mark(this.subject, value);
            student.
                Marks
                .Add(mark);
        }
    }
}
