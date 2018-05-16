namespace Problem_01.Persons
{
    using System;

    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age) : this(name, age, null)
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name is empty");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Age must be in the range [1 ... 100]");
                }

                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (value == string.Empty && value.Contains("@"))
                {
                    this.email = value;
                }
            }
        }

        public static void Main()
        {
            Console.Write("Insert name: ");
            string name = Console.ReadLine();
            Console.Write("Insert age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Insert email: ");
            string email = Console.ReadLine();

            Person newPerson = new Person(name, age, email);

            Console.WriteLine(newPerson);
        }

        public override string ToString()
        {
            return string.Format(
                "Person, name: {0}, age: {1}, email: {2}",
                this.name, 
                this.age, 
                this.email);
        }
    }
}
