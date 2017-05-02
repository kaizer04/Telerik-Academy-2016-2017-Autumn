namespace SchoolSystem.Commands
{
    using System.Collections.Generic;

    public class TeacherAddMarkCommand : ICommand
    {
        public string Execute(IList<string> teacherMarksInfo)
        {
            var teecherId = int.Parse(teacherMarksInfo[0]);
            var studentId = int.Parse(teacherMarksInfo[1]);

            // Please work
            var student = Engine.Students[teecherId];
            var teacher = Engine.Teachers[studentId];

            teacher.AddMark(student, float.Parse(teacherMarksInfo[2]));

            return $"Teacher {teacher.firstName} {teacher.lastName} added mark {float.Parse(teacherMarksInfo[2])} to student {student.FirstName} {student.LastName} in {teacher.subject}.";
        }
    }
}
