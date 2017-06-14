using System.Collections.Generic;

namespace SchoolSystem.Framework.Models.Contracts
{
    public interface ISchool : IAddStudent, IAddTeacher, IRemoveStudent, IRemoveTeacher, IGetStudentAndTeacher
    {
    }
}