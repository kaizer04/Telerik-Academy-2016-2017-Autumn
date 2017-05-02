namespace SchoolSystem.Commands
{
    using System.Collections.Generic;

    using Models;

    public class CreateStudentCommand
    {
        // TODO: id move to Student class
        private static int id = 0;

        public string Execute(IList<string> studentInputInfo)
        {
            Engine.Students.Add(id, new Student(studentInputInfo[0], studentInputInfo[1], (Grade)int.Parse(studentInputInfo[2])));

            // TODO: big fix ID
            return $"A new student with name {studentInputInfo[0]} {studentInputInfo[1]}, grade {(Grade)int.Parse(studentInputInfo[2])} and ID {id++} was created.";
        }
    }
}
