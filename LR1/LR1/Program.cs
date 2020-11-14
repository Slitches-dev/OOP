using System;
using System.Collections.Generic;
using System.Text;

namespace LR1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Name = "Cat";
            animal.Age = 3;
            animal.NumberOfLimbs = 4;
            animal.KindOfAnimal = KindsOfAnimal.omnivorous;
            animal.Habitat = Habitats.earth;
            animal.Continent = Continents.All;

            Animal animal1 = new Animal();
            animal.Name = "Dog";
            animal.Age = 5;
            animal.NumberOfLimbs = 4;
            animal.KindOfAnimal = KindsOfAnimal.omnivorous;
            animal.Habitat = Habitats.earth;
            animal.Continent = Continents.All;

            Console.WriteLine(animal == animal1);
            Console.WriteLine(animal.Info());
            Console.ReadKey();
        } 
    }
}
