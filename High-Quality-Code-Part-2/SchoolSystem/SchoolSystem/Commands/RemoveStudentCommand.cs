namespace SchoolSystem.Commands
{
    using System.Collections.Generic;

    public class RemoveStudentCommand : ICommand
    {
        public string Execute(IList<string> students)
        {
            Engine.Students.Remove(int.Parse(students[0]));

            return $"Student with ID {int.Parse(students[0])} was sucessfully removed.";
        }
    }
}
