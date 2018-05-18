namespace _02.Animals
{
    using System;

    public class Cat : Animals
    {
        public Cat(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("said miau!");
        }

        public override string ToString()
        {
            return string.Format(
                "Cat {0} is {1} year old, gender {2}", this.Name, this.Age, this.Gender);
        }
    }
}