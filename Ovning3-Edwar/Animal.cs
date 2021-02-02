using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3_Edwar
{
    abstract class Animal
    {
        private string _name;
        private int _weight;
        private int _age;
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }

        public Animal(string name, int weight, int age)  // Constructor
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
        public abstract string DoSound();
        public virtual string Stats()
        {
            return $"Name: {Name}, Weight: {Weight}, Age: {Age}, ";
        }
    }
    class Horse : Animal   // create Horse class and inhert Animal class properties 
    {
        public string Breed { get; set; } // create a new property in the horse class

        //The horse constructor with name, weight, and age  inhereted from the base class animal
        public Horse(string name, int weight, int age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }
        public override string DoSound() // overriding the abstract DoSound() method which is emplicitly avirtual  method,  returning the sound
        {
            return "*Horse sound*";
        }
        public override string Stats()  // Override the virtual method and write my own method by returning Breed too
        {
            return base.Stats() + $"Breed: {Breed}.";
        }
    }
    //------------------------------------------------------------------------
    class Dog : Animal
    {
        public string Tail { get; set; }
        public Dog(string name, int weight, int age, string tail) : base(name, weight, age)
        {
            Tail = tail;
        }
        public string DogMethod()
        {
            return "This is the dog method";
        }
        public override string DoSound()
        {
            return "*Dog sound*";
        }
        public override string Stats()
        {
            return base.Stats() + $"Tail: {Tail}.";
        }
    }
    //---------------------------------------------
    class Bird : Animal
    {
        public string Wing { get; set; }
        // the constructor is enheriting the name, weight and age from the animal class. 
        // all the paramenters form the brid class plus the base class properties
        public Bird(string name, int weight, int age, string wing) : base(name, weight, age)
        {
            Wing = wing;
        }
        public override string DoSound()
        {
            return "*Bird sound*";
        }
        public override string Stats()
        {
            return base.Stats() + $"Wing: {Wing}.";
        }
    }
    //--------------------------------------------------------------

    class Pelican : Bird
    {
        public string Legs { get; set; }
        // we have added wing to the Pelican and the base class, else we get an error.
        public Pelican(string name, int weight, int age, string legs, string wing) : base(name, weight, age, wing)
        {
            Legs = legs;
        }
        public override string DoSound()
        {
            return "*Bird sound*";
        }
        public override string Stats()
        {
            return base.Stats() + $"Legs: {Legs}.";
        }
    }
    //----------------------------------------------------------------
    class Wolf : Animal   // create Horse class and inhert Animal class properties 
    {
        public string WolfEars { get; set; } // create a new property in the horse class

        //The horse constructor with name, weight, and age  inhereted from the base class animal
        public Wolf(string name, int weight, int age, string wolfEars) : base(name, weight, age)
        {
            WolfEars = wolfEars;
        }
        public override string DoSound() // overriding the abstract DoSound() method which is emplicitly avirtual  method,  returning the sound
        {
            return "*Wolf sound*";
        }

        public override string Stats()  // Override the virtual method and write my own method by returning Breed too
        {
            return base.Stats() + $"WolfEars: {WolfEars}.";
        }
    }
    // ----------------------------------------------------------------
    // inheriting from Wolf and implemmetning IPerson interface
    class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int weight, int age, string wolfEars) : base(name, weight, age, wolfEars)
        {
            WolfEars = wolfEars;
        }
        public string Talk()
        {
            return "HOOOOOOOH";
        }
    }
}
