﻿namespace StudentsDataManagement
{
    using System.Collections.Generic;

    /// <summary>
    /// Problem 1. Class Student.
    /// Create a class Student with properties FirstName, LastName, Age, FacultyNumber, Phone, Email,Marks, GroupNumber. 
    /// </summary>
    public class Student
    {
        public Student(
            string firstName,
            string lastName,
            int age,
            string facultyNumber,
            string phone,
            string email,
            IList<int> marks,
            int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public string FacultyNumber
        {
            get;
            set;
        }

        public string Phone
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public IList<int> Marks
        {
            get;
            set;
        }

        public int GroupNumber
        {
            get;
            set;
        }
    }
}