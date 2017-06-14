using System;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;
using SchoolSystem.Framework.Models;

namespace SchoolSystem.Framework.Contracts
{
    public interface IStudentFactory
    {
        IStudent CreateStudent(string firstName, string lastName, Grade grade);
    }

    public class StudentFactory : IStudentFactory
    {
        public IStudent CreateStudent(string firstName, string lastName, Grade grade)
        {
            return new Student(firstName, lastName, grade);
        }
    }
}