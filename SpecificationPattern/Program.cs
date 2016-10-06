using SpecificationPattern.Model;
using SpecificationPattern.Specification;
using System;
using System.Collections.Generic;

namespace SpecificationPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var animals = GetAnimals();

            foreach (Animal animal in animals)
            {
                if (AnimalSpecifications.Normal.IsSatisfiedBy(animal))
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine(animal.Id.ToString());
                    Console.WriteLine("State: Normal");
                    Console.WriteLine("---------------------");
                }
                else if (AnimalSpecifications.InTreatment.IsSatisfiedBy(animal))
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine(animal.Id);
                    Console.WriteLine("State: In Treatment");
                    Console.WriteLine("---------------------");
                }
                else if (AnimalSpecifications.Dead.IsSatisfiedBy(animal))
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine(animal.Id);
                    Console.WriteLine("State: Dead");
                    Console.WriteLine("---------------------");
                }
            }
        }

        public static List<Animal> GetAnimals()
        {
            var animalOne = new Animal()
            {
                Id = 1,
                BirthdayDate = DateTime.Now
            };

            var animalTwo = new Animal()
            {
                Id = 2,
                BirthdayDate = DateTime.Now,
                DeathDate = DateTime.Now
            };

            var animalThree = new Animal()
            {
                Id = 3,
                BirthdayDate = DateTime.Now
            };
            animalThree.Treatments =
                new List<Treatment>()
                {
                    new Treatment()
                    {
                        Id = 101,
                        InTreatment = true,
                        AnimalId = animalThree.Id,
                        Animal = animalThree
                    }
                };

            return new List<Animal>() { animalOne, animalTwo, animalThree };
        }
    }
}