namespace _02.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartProgramAnimal
    {
        public static void Main()
        {
            var animals = new List<Animals>();
            animals.Add(new Dog("Ben", 4, Gender.male));
            animals.Add(new Dog("Mery", 1, Gender.female));
            animals.Add(new Dog("Dino", 6, Gender.male));
            animals.Add(new Frog("Fil", 2, Gender.male));
            animals.Add(new Frog("Ria", 1, Gender.female));
            animals.Add(new Tomcat("Tom", 5));
            animals.Add(new Kitten("Lina", 4));

            foreach (var animal in animals)
            {
                Console.Write(animal + ", "); 
                animal.ProduceSound();
            }

            Console.WriteLine();

            double averageAge = animals.Select(a => a.Age).Average();

            Console.WriteLine("Average age of each kind of animal: {0:f2}", averageAge);
        }
    }
}
