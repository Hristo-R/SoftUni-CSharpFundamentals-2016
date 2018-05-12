namespace StudentsDataManagement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MainProgram
    {
        public static void Main()
        {
            // List with sample students. 
            List<Student> listOfStudents = new List<Student>
            {
                new Student("Asya", "Manova", 30, "203314", "0811123456", "asyamanova1996@abv.bg", new List<int> { 6, 5, 6 }, 1),
                new Student("Asya", "Asenova", 23, "203315", "+359 2 1123456", "asya_apostolova@abv.bg", new List<int> { 5, 2, 6 }, 1),
                new Student("Diana", "Petrova", 20, "203914", "+3592 2234567", "didi.petrova@gmail.com", new List<int> { 2, 4, 2 }, 2),
                new Student("Ivan", "Ivanov", 24, "203814", "0812345678", "ivan_ivanov_bg@abv.bg", new List<int> { 6, 5, 4 }, 1),
                new Student("Stefan", "Popov", 26, "203114", "0813987654", "stefan_popov_90@abv.bg", new List<int> { 2, 2, 6 }, 2),
                new Student("Milena", "Kirova", 38, "215314", "02 1345678", "MilenaKirova@mail.bg", new List<int> { 5, 3, 4 }, 2)
            };

            // Problem 2. Students by Group
            int groupNumber = 2;
            Console.WriteLine("Problem 2. Students by Group 2:");
            PrintCollection(GetStudentsFromGroup(listOfStudents, groupNumber));

            // Problem 3. Students by First and Last Name
            Console.WriteLine("Problem 3. Students whose first name is before their last name alphabetically:");
            PrintCollection(StudentsByFirstAndLastName(listOfStudents));

            // Problem 4. Students by Age
            Console.WriteLine("Problem 4. First name and last name of all students with age between 18 and 24:");
            StudentsByAge(listOfStudents);

            // Problem 5. Sort Students
            Console.WriteLine("Problem 5. Sorting students by first name and last name in descending order.");
            PrintCollection(SortStudentsByName(listOfStudents));

            // Problem 6. Filter Students by Email Domain
            Console.WriteLine("Problem 6. All students that have email @abv.bg:");
            PrintCollection(FindStudentsEmail(listOfStudents));

            // Problem 7. Filter Students by Phone
            Console.WriteLine("Problem 7. Prints all students with phones in Sofia (starting with 02 / +3592 / +359 2:");
            PrintCollection(FindStudentsPhone(listOfStudents));

            // Problem 8. Excellent Students
            Console.WriteLine("Problem 8. Prints all students that have at least one mark Excellent (6).");
            FindExcellentStudents(listOfStudents);

            // Problem 9. Weak Students
            Console.WriteLine("Problem 9. Prints all students with exactly two marks 2.");
            FindWeakStudents(listOfStudents);

            // Problem 10. Students Enrolled in 2014
            Console.WriteLine("Problem 10. Marks of all students that enrolled in 2014.");
            FindStudentsEnrolledIn2014(listOfStudents);
        }

        /// <summary>
        /// Problem 2. Extract students by Group 2.
        /// Returns list of students from group number 2 ordered by first name.
        /// </summary>
        /// <param name="listOfStudents">List of students</param>
        /// <param name="groupNumber">Group number 2</param>
        /// <returns>IOrderedEnumerable collection students</returns>
        private static IEnumerable<Student> GetStudentsFromGroup(List<Student> listOfStudents, int groupNumber)
        {
            var studentsFromGroup2 = from student in listOfStudents
                                     where student.GroupNumber == groupNumber
                                     orderby student.FirstName
                                     select student;
            return studentsFromGroup2;
        }

        /// <summary>
        /// Problem 3. Extract students by First and Last Name.
        /// Returns list of students whose first name is before their last name alphabetically. 
        /// </summary>
        /// <param name="listOfStudents">List of students</param>
        /// <returns>IOrderedEnumerable collection students</returns>
        private static IEnumerable<Student> StudentsByFirstAndLastName(List<Student> listOfStudents)
        {
            var students = from student in listOfStudents
                           where student.FirstName.CompareTo(student.LastName) < 0
                           orderby student.FirstName
                           select student;
            return students;
        }

        /// <summary>
        /// Problem 4. Students by Age.
        /// Finds the first name and last name of all students with age between 18 and 24.
        /// Prints only the first name, last name and age. 
        /// </summary>
        /// <param name="listOfStudents">List of students</param>
        private static void StudentsByAge(List<Student> listOfStudents)
        {
            var students = from student in listOfStudents
                           where student.Age >= 18 && student.Age <= 24
                           orderby student.FirstName
                           select student;
            foreach (var student in students)
            {
                Console.Write(
                    "Name: {0} {1}\tAge: {2}",
                    student.FirstName,
                    student.LastName,
                    student.Age);
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Problem 5. Sort Students.
        /// Sorting students by first name and last name in descending order.
        /// </summary>
        /// <param name="listOfStudents">List of students</param>
        /// <returns>IOrderedEnumerable collection students</returns>
        private static IEnumerable<Student> SortStudentsByName(List<Student> listOfStudents)
        {
            var students = listOfStudents
                .OrderByDescending(student => student.FirstName)
                .ThenByDescending(student => student.LastName);
            return students;
        }

        /// <summary>
        /// Problem 6. Filter Students by Email Domain.
        /// Returns all students that have email @abv.bg.
        /// </summary>
        /// <param name="listOfStudents">List of students</param>
        /// <returns>IOrderedEnumerable collection students</returns>
        private static IEnumerable<Student> FindStudentsEmail(List<Student> listOfStudents)
        {
            var students = listOfStudents.FindAll(student => student.Email.Contains("@abv.bg"));
            return students;
        }

        /// <summary>
        /// Problem 7. Filter Students by Phone.
        /// Prints all students with phones in Sofia (starting with 02 / +3592 / +359 2).  
        /// </summary>
        /// <param name="listOfStudents">List of students</param>
        /// <returns>IOrderedEnumerable collection students</returns>
        private static IEnumerable<Student> FindStudentsPhone(List<Student> listOfStudents)
        {
            var students = listOfStudents.FindAll(student =>
                student.Phone.Contains("02 ") ||
                student.Phone.Contains("+3592") ||
                student.Phone.Contains("+359 2"));
            return students;
        }

        /// <summary>
        /// Problem 8. Excellent Students.
        /// Prints all students that have at least one mark Excellent (6).  
        /// </summary>
        /// <param name="listOfStudents">List of students</param>
        private static void FindExcellentStudents(List<Student> listOfStudents)
        {
            var excellentStudents = from student in listOfStudents
                where (student.Marks.Max() == 6)
                select new
                {
                    Fullname = string.Join(" ", student.FirstName, student.LastName), Marks = string.Join(" ", student.Marks)
                };

            foreach (var student in excellentStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Problem 9. Weak Students.
        /// Prints all students with exactly two marks 2.  
        /// </summary>
        /// <param name="listOfStudents">List of students</param>
        private static void FindWeakStudents(List<Student> listOfStudents)
        {
            var weakStudents = from student in listOfStudents
                                    where (student.Marks.Count(x => x == 2) == 2)
                                    select new
                                    {
                                        Fullname = string.Join(" ", student.FirstName, student.LastName),
                                        Marks = string.Join(" ", student.Marks)
                                    };

            foreach (var student in weakStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Problem 10. Students Enrolled in 2014.
        /// Marks of all students that enrolled in 2014. 
        /// </summary>
        /// <param name="listOfStudents">List of students</param>
        private static void FindStudentsEnrolledIn2014(List<Student> listOfStudents)
        {
            var students = from student in listOfStudents
                           where student.FacultyNumber.EndsWith("14")
                           select new
                           {
                               Marks = string.Join(" ", student.Marks)
                           };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Print processed list of students.
        /// </summary>
        /// <param name="processedList">processed list of students</param>
        private static void PrintCollection(IEnumerable<Student> processedList)
        {
            foreach (var student in processedList)
            {
                Console.Write(
                    "Name: {0} {1}\tAge: {2}\tfN: {3}\tphone: {4}\te-mail: {5}\tmarks: {6}\tgroup: {7}",
                    student.FirstName, 
                    student.LastName, 
                    student.Age, 
                    student.FacultyNumber, 
                    student.Phone, 
                    student.Email,
                    string.Join(" ", student.Marks), 
                    student.GroupNumber);
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
