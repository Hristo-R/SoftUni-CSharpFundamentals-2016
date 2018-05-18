namespace _01.HumanStudentAndWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartProgramHuman
    {
        public static void Main()
        {
            var students = new List<Student>();
            students.Add(new Student("Ivo", "Manev", "DF2456"));
            students.Add(new Student("Ina", "Ivanova", "GU0987"));
            students.Add(new Student("Petko", "Notev", "SH0020"));
            students.Add(new Student("Nina", "Semova", "AB0900"));
            students.Add(new Student("Stoyan", "Venev", "SU2011"));
            students.Add(new Student("Dobri", "Patev", "TY9832"));
            students.Add(new Student("Tomi", "Kolev", "KL5643"));
            students.Add(new Student("John", "Smith", "MV3265"));
            students.Add(new Student("Zdravko", "Tonev", "QW5674")); 
            students.Add(new Student("Yordan", "Angelov", "IL2301"));

            Console.WriteLine("Students sorted by faculty number:");

            var sortedStudentsByFacultyNumber = students.OrderBy(person => person.FacultyNumber);
            foreach (var student in sortedStudentsByFacultyNumber)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            var workers = new List<Worker>();
            workers.Add(new Worker("Hans", "Shtain", 400.00m, 8.00));
            workers.Add(new Worker("Petko", "Donev", 200.00m, 8.00));
            workers.Add(new Worker("Ana", "Ivanova", 425.00m, 5.00));
            workers.Add(new Worker("Pepi", "Notev", 1000.00m, 1.00));
            workers.Add(new Worker("Iva", "Genova", 500.00m, 5.00));
            workers.Add(new Worker("Stoyan", "Donev", 150.00m, 7.00));
            workers.Add(new Worker("Dony", "Mishev", 300.00m, 6.00));
            workers.Add(new Worker("Antoni", "Rusev", 1500.00m, 10.00));
            workers.Add(new Worker("John", "Smith", 225.00m, 2.00));
            workers.Add(new Worker("Joro", "Venev", 2500.00m, 12.00));

            Console.WriteLine("Workers sorted by payment per hour:");
            var sortedWorkersByPayment = workers.OrderByDescending(person => person.MoneyPerHour());

            foreach (var worker in sortedWorkersByPayment)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine();

            var allPeople = new List<Human>();
            allPeople.AddRange(students);
            allPeople.AddRange(workers);

            Console.WriteLine("All people sorted by first name:");
            var sortedPeopleByFirstName = allPeople.OrderBy(person => person.FirstName);
            foreach (var people in sortedPeopleByFirstName)
            {
                Console.WriteLine(people);
            }

            Console.WriteLine();

            Console.WriteLine("All people sorted by last name:");
            var sortedPeopleByLastName = allPeople.OrderBy(person => person.LastName);

            foreach (var people in sortedPeopleByLastName)
            {
                Console.WriteLine(people);
            }
        }
    }
}
