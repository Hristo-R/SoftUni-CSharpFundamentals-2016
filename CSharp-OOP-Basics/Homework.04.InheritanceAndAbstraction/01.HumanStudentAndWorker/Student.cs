namespace _01.HumanStudentAndWorker
{
    using System;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Length should be in range 5 - 10 digits / letters");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Student {0} {1}, faculty number: {2}", this.FirstName, this.LastName, this.FacultyNumber);
        }
    }
}