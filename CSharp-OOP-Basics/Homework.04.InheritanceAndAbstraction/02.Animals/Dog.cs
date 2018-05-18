namespace _02.Animals
{
    using System;

    public class Dog : Animals
    {
        public Dog(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("said bark!");
        }

        public override string ToString()
        {
            return string.Format(
                "Dog {0} is {1} year old, gender {2}", this.Name, this.Age, this.Gender);
        }
    }
}
