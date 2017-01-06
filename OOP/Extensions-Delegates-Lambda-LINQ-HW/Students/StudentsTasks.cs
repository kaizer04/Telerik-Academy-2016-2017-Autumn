namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsTasks
    {
        // Problem 3-5
        private static List<Student> students = new List<Student>
        {
            new Student("Ivan", "Ivanov", 20) ,
            new Student("Stamat", "Petrov", 19),
            new Student("Stoyan", "Ivanov", 16),
            new Student("Iva" , "Avramova", 24),
            new Student ("Greta", "Petrova", 28),
        };

        // Problem 9-16
        private static List<Student> listStudents = new List<Student>()
        {
            new Student("Ivan", "Stoyanov", "40623361","0267888099", "ivan@abv.bg", 3, 3, 3, 3, 5, 4, 2),
            new Student("Stoyan", "Ganchev", "10511111", "+359297145123", "ganchoka@yahoo.com", 2, 2, 2, 2, 2),
            new Student("Mira", "Radeva", "40620661","+359877543564", "radeva.mira@abv.bg", 2, 6, 6, 6, 3),
            new Student("Ivaylo", "Yordanov", "60810645","+359878232301", "ikenov@gmail.bg", 3, 6, 6, 6, 4, 6, 2),
            new Student("Boris", "Beker", "84488888","073398756", "bbeker@abv.bg", 2, 2, 2, 3, 4),
            new Student("Nora", "Paskaleva", "50614514","+35946656565", "kaizer@abv.bg", 2, 6, 6, 6, 4, 6, 2),
            new Student("Kichka", "Bodurova", "60812345","+359888136384", "kaizer0505@gmail.bg", 2, 2, 3, 3, 4, 3, 2)
        };

        // Problem 18-19
        private static List<Group> groups = new List<Group>()
        {
            new Group(1, "Physics"),
            new Group(2, "Arts"),
            new Group(3, "Mathematics"),
            new Group(4, "Law"),
            new Group(5, "Medicine"),
            new Group(6, "Biology"),
        };

        // Problem 3.
        private static void FirstBeforeLast()
        {
            var firstNameBeforeLastNameAlphabetically =
                    from student in students
                    where student.FirstName.CompareTo(student.LastName) < 0
                    select student;

            Console.WriteLine("Students whose First Name is before Last Name alphabetically: ");
            foreach (var item in firstNameBeforeLastNameAlphabetically)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }

        // Problem 4.
        private static void AgeRange()
        {
            var studentsWithAgeBetween18and24 =
                        from student in students
                        where student.Age >= 18 && student.Age <= 24
                        select student;

            Console.WriteLine("Students between 18 and 24 age: ");
            foreach (var item in studentsWithAgeBetween18and24)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }

        // Problem 5.
        private static void OrderStudentsTroughLambda()
        {
            var sortedStudentsFirstNameLastNameDescending = students
                                                            .OrderByDescending(st => st.FirstName)
                                                            .ThenByDescending(st => st.LastName);

            Console.WriteLine("Sorted by FirstName and Last Name trough Lambda: ");
            foreach (var item in sortedStudentsFirstNameLastNameDescending)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }

        private static void OrderStudentsTroughLinq()
        {
            var sortedStudentsFirstNameLastNameDescending =
                            from student in students
                            orderby student.FirstName descending, student.LastName descending
                            select student;

            Console.WriteLine("Sorted by FirstName and Last Name trough Linq:");
            foreach (var item in sortedStudentsFirstNameLastNameDescending)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }

        public static void Main()
        {
            // Problem 3-5
            FirstBeforeLast();

            AgeRange();

            OrderStudentsTroughLambda();

            OrderStudentsTroughLinq();

            // Problem 9-16
            StudentGroups();

            StudentGroupsExtensions();

            ExtractStudentsByEmail();

            ExtractStudentsByPhone();

            ExtractStudentsByMarks();

            ExtractMarks();

            ExtractAllStudentsFromMathematicsDepartment();

            // Problem 18-19
            ExtractAllStudentsGroupedByGroupNumber();

            GroupedByGroupNumberExtensions();
        }

        // Problem 19
        private static void GroupedByGroupNumberExtensions()
        {
            var orderedStudentsByGroupNumber = listStudents.OrderByGroupNumber();

            foreach (var student in orderedStudentsByGroupNumber)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }

        // Problem 18.
        private static void ExtractAllStudentsGroupedByGroupNumber()
        {
            var studentsFromGroup = from student in listStudents
                                               orderby student.GroupNumber
                                               select student;

            foreach (var student in studentsFromGroup)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }

        // Problem 16.
        private static void ExtractAllStudentsFromMathematicsDepartment()
        {
            var studentsFromGroupMathematics = from student in listStudents
                                               join grp in groups on student.GroupNumber equals grp.GroupNumber
                                               where grp.DepartmentName == "Mathematics"
                                               select student;

            foreach (var student in studentsFromGroupMathematics)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }

        // Problem 15.
        private static void ExtractMarks()
        {
            var marksFromStudentsEnrolledIn2006 = from student in listStudents
                                                  where student.FacultyNumber.ElementAt(4) == '0' && student.FacultyNumber.ElementAt(5) == '6'
                                                  select student.Marks;

            List<int> allMarks = new List<int>();

            foreach (var mark in marksFromStudentsEnrolledIn2006)
            {
                allMarks.AddRange(mark);
            }

            Console.WriteLine(string.Join(", ", allMarks));
        }

        // Problem 14.
        private static void ExtractStudentsWithTwoMarks()
        {
            List<Student> studentsWithTwoMarksTwo = listStudents.GetListOfStudentsWithNumberOfMarks(2, 2);

            foreach (var student in studentsWithTwoMarksTwo)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }

        // Problem 13.
        private static void ExtractStudentsByMarks()
        {
            var studentsWithAtLeastOneExcellent = from student in listStudents
                                                  where student.Marks.Contains(6)
                                                  select new
                                                  {
                                                      FullName = string.Format("{0} {1}", student.FirstName, student.LastName),
                                                      Marks = student.Marks
                                                  };

            foreach (var student in studentsWithAtLeastOneExcellent)
            {
                Console.WriteLine(student.FullName + "'s marks: " + string.Join(", ", student.Marks));
            }
        }

        // Problem 12.
        private static void ExtractStudentsByPhone()
        {
            var studentsWithPhonesInSofia = from student in listStudents
                                            where student.Telephone.StartsWith("+3592") || student.Telephone.StartsWith("02")
                                            select student;

            foreach (var student in studentsWithPhonesInSofia)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }

        // Problem 11.
        private static void ExtractStudentsByEmail()
        {
            var studentsWithMailInAbv = from student in listStudents
                                        where student.Email.Substring(student.Email.LastIndexOf("@")) == "@abv.bg"
                                        select student;

            foreach (var student in studentsWithMailInAbv)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }

        // Problem 10.
        private static void StudentGroupsExtensions()
        {
            List<Student> studentsFromGroupTwo = listStudents.GetListOfStudentsInExactGroup(2);

            foreach (var student in studentsFromGroupTwo)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

        }

        // Problem 9.
        private static void StudentGroups()
        {
            var selectedStudentsGroupNumberTwo =
                from student in listStudents
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            foreach (var student in selectedStudentsGroupNumberTwo)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}