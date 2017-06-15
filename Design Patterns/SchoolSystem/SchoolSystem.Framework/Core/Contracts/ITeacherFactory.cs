using System;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;
using SchoolSystem.Framework.Models;

namespace SchoolSystem.Framework.Core.Contracts
{
    public interface ITeacherFactory
    {
        ITeacher CreateTeacher(string firstName, string lastName, Subject subject);
    }

    //public class TeacherFactory : ITeacherFactory
    //{
    //    public ITeacher CreateTeacher(string firstName, string lastName, Subject subject)
    //    {
    //        return new Teacher(firstName, lastName, subject, new MarkFactory());
    //    }
    //}
}