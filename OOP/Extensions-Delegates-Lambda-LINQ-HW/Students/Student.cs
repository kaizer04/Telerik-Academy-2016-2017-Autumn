namespace Students
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
		private List<int> marks;
	
		public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
		
		public Student(string firstName, string lastName, string fn, string tel, string email, int groupNumber, params int[] inputMarks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = fn;
            this.Telephone = tel;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.marks = new List<int>(inputMarks);
		}
		
		public string FirstName { get; private set; }
		
        public string LastName { get; private set; }
		
        public int Age { get; private set; }
		
		public string FacultyNumber { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }
		
		public List<int> Marks
        {
            get
            {
                return new List<int>(this.marks);
            }
		}
		
		public int GroupNumber { get; set; }
		
		public Group Group { get; set; }
    }
}