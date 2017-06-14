using System.Collections.Generic;
using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Models;
using SchoolSystem.Framework.Models.Enums;
using SchoolSystem.Framework.Contracts;

namespace SchoolSystem.Framework.Core.Commands
{
    public static class SchoolSystemFactory
    {
        ////public static Student CreateStudent(string firstName, string lastName, Grade grade)
        ////{
        ////    return new Student(firstName, lastName, grade);
        ////}
    }

    public class CreateStudentCommand : ICommand
    {
        private static int currentStudentId = 0;
        private readonly IStudentFactory studentFactory;

        public CreateStudentCommand(IStudentFactory studentFactory)
        {
            this.studentFactory = studentFactory;
        }

        public string Execute(IList<string> parameters)
        {
            var firstName = parameters[0];
            var lastName = parameters[1];
            var grade = (Grade)int.Parse(parameters[2]);

            var student = this.studentFactory.CreateStudent(firstName, lastName, grade);
            ////var student = SchoolSystemFactory.CreateStudent(firstName, lastName, grade);
            Engine.Students.Add(currentStudentId, student);

            return $"A new student with name {firstName} {lastName}, grade {grade} and ID {currentStudentId++} was created.";
        }
    }
}
