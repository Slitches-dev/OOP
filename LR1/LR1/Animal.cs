using System;
using System.Collections.Generic;
using System.Text;

namespace LR1
{
    class Animal
    {
        #region
        private string _name;
        private string _kindOfAnimal;
        private string _habitat;
        private string _continent;
        private int _age;
        private int _numberOfLimbs;
        #endregion

        public Animal()
        {
            KindOfAnimal = KindsOfAnimal.herbivorous;
            Habitat = Habitats.earth;
            Continent = Continents.Europe;
        }

        public Animal(string name, int age, int numberOfLimbs, KindsOfAnimal kindOfAnimal = KindsOfAnimal.herbivorous)
        {
            _age = age;
            _name = name;
            _numberOfLimbs = numberOfLimbs;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public int NumberOfLimbs
        {
            get { return _numberOfLimbs; }
            set { _numberOfLimbs = value; }
        }

        public KindsOfAnimal KindOfAnimal
        {
            get;
            set;
        }

        public Habitats Habitat
        {
            get;
            set;
        }

        public Continents Continent
        {
            get;
            set;
        }

        public static bool operator == (Animal animal, Animal animal1)
        {
            return ((animal.KindOfAnimal == animal1.KindOfAnimal) && (animal.Habitat == animal1.Habitat) && (animal.Continent == animal1.Continent)) ? true : false;
        }

        public static bool operator != (Animal animal, Animal animal1)
        {
            return ((animal.KindOfAnimal == animal1.KindOfAnimal) && (animal.Habitat == animal1.Habitat) && (animal.Continent == animal1.Continent)) ? true : false;
        }

        public string GetSound()
        {
            if (Name == "Cat") return string.Format("Meow");
            else return string.Format("Gav");
        }

        public string CanFly()
        {
            if (Habitat == Habitats.air) return string.Format("Yes");
            else return string.Format("No");
        }

        public string CanSwim()
        {
            if (Habitat == Habitats.water) return string.Format("Yes");
            else return string.Format("No");
        }

        public string Info()
        {
            return string.Format($"Имя {this.Name} Возраст {this.Age} Вид {this.NumberOfLimbs} Среда обитания {this.KindOfAnimal} Континент {this.Continent}");
        }
    }
}
