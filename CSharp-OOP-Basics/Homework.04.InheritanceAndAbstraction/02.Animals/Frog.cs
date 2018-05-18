namespace _02.Animals
{
    using System;

    public class Frog : Animals
    {
        public Frog(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("said kvak!");
        }

        public override string ToString()
        {
            return string.Format(
                "Frog {0} is {1} year old, gender {2}", this.Name, this.Age, this.Gender);
        }
    }
}