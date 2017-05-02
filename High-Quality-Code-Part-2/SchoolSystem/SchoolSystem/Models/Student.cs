namespace SchoolSystem.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        // This code sucks, you know it and I know it.
        // Move on and call me an idiot later.
        // private string firstName;
        // private string lastName;
        public Student(string firstName, string lastName, Grade grades)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grades = grades;
            this.Marks = new List<Mark>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Grade Grades { get; set; }

        public IList<Mark> Marks { get; set; }

        public string ListMarks()
        {
            var potatos = this.Marks.Select(m => $"{m.subject} => {m.value}").ToList();
            return string.Join("\n", potatos);
        }
    }
}
