namespace _01.HumanStudentAndWorker
{
    using System;

    public class Worker : Human
    {
        private const int WorkDaysPerWeek = 5;
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary should be positive");
                }

                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Work hours should be positive");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.weekSalary / (decimal)(this.workHoursPerDay * WorkDaysPerWeek);
        }

        public override string ToString()
        {
            return string.Format("Worker  {0} {1}, earned by hour: {2:f2}", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
