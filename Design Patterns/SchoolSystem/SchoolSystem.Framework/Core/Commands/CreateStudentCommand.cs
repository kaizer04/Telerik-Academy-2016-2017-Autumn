﻿using System.Collections.Generic;
using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Models;
using SchoolSystem.Framework.Models.Enums;
using SchoolSystem.Framework.Contracts;
using SchoolSystem.Framework.Models.Contracts;

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
        private int currentStudentId = 0;
        private readonly IStudentFactory studentFactory;
        private readonly IAddStudent addStudent;

        public CreateStudentCommand(IStudentFactory studentFactory, IAddStudent addStudent)
        {
            this.studentFactory = studentFactory;
            this.addStudent = addStudent;
        }

        public string Execute(IList<string> parameters)
        {
            var firstName = parameters[0];
            var lastName = parameters[1];
            var grade = (Grade)int.Parse(parameters[2]);

            var student = this.studentFactory.CreateStudent(firstName, lastName, grade);
            ////var student = SchoolSystemFactory.CreateStudent(firstName, lastName, grade);
            this.addStudent.AddStudent(currentStudentId, student);

            return $"A new student with name {firstName} {lastName}, grade {grade} and ID {currentStudentId++} was created.";
        }
    }
}
