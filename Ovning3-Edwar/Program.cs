/*
 Del 3.2
13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i
vilken klass bör vi lägga det?
Svar: i Bird klassen
F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
Svar: i animal klassen

Del 3.3
9. F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
Svar: Jag hunit inte med att skapa hundar lista. Svart kan vara att häst är en klass i sig
10. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
Svar: Animal typ
11. Skriv ut samtliga Animals Stats() genom en foreach loop.
12. Testa och se så det fungerar.
13. F: Förklara vad det är som händer.
Svar: Den skriver ut varje animal som finns i
14.Skriv ut Stats() metoden enbart för alla hundar genom en foreach på Animals.
Svar: Jag har stats() metoden for alla djur, jag hunit inte med enbart hundar.
15. Skapa en ny metod med valfritt namn i klassen Dog som endast returnerar en valfri sträng.
16. Kommer du åt den metoden från Animals listan?
17. F: Varför inte?
18. Hitta ett sätt att skriva ut din nya metod för dog genom en foreach på Animals.
Svar: Genom at använda type cast, se nedan  "foreach (var animal in animals)" 

Del 3.4
11. F: Varför är polymorfism viktigt att behärska?
Svar: Den är en av de tre Pilars i OOP. Utan des, det kan vara svart att lägga till nya metoder och extendera klasser.
Man kan lägga till hur många som helst interfaces. Den är som Scott säger "The ultimate abstraction, becasuse it define
the API (application programming interface) your softare needs without defining any of the implemenation details"
12. F: Hur kan polymorfism förändra och förbättra kod via en bra struktur?
Svar: Scott säger "When I inherit from an abstract class I only can inherit from a single base class, but I can inherit many interfaces, 
I can enherit one or ten, I can also inherit from a base class and 10 interfaces as long as they are defined"
13. F: Vad är det för en skillnad på en Abstrakt klass och ett Interface?
Svar: En abstract class kan inte instantiseras, medan ett Interface liknar en implicit abstract klass och det är bättre än
abstract klass när man aplikera polimorfism, aftersom man skapper ingen kjeda som kan ledda till komplikation i framtiden.
 */


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3_Edwar
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonHandler handler = new PersonHandler();

            //Person kalle = new Person();
            //handler.SetAge(kalle, 55);
            //Debug.WriteLine(kalle.Age);

            //try
            //{
            //    handler.SetAge(kalle, -3);

            //}
            //catch (Exception e)
            //{
            //    Debug.WriteLine(e.Message);
            //}
            //Debug.WriteLine(kalle.Age);

            //Person joe = handler.CreatePerson(12, "Joe", "Bo", 180, 95);
            //handler.SetAge(joe, 56);

            //person.SetAge(-55);
            //Debug.WriteLine(person.Fname);
            //try
            //{   
            //    person.SetAge(-55);
            //}
            //catch (ArgumentException e)
            //{

            //    Console.WriteLine(e.Message);
            //}
            //Debug.WriteLine(person.Age);

            Person person = new Person();
            try
            {
                person.SetFname("m");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Debug.WriteLine(person.Fname);
            //-----------------------------------------

            Person personLname = new Person();
            try
            {
                person.Setlname("j");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Debug.WriteLine(person.Fname);
            //----------------------------------------------

            // Part 3.2: Abstract class Animal and the classes that inherit from it.
            Horse horse1 = new Horse("Sleipnir", 500, 10, "Arabic");
            Console.WriteLine(horse1.GetType().Name);
            Console.WriteLine(horse1.DoSound());
            Console.WriteLine(horse1.Stats());

            Dog dog1 = new Dog("Sam", 10, 5, "Lap");
            Console.WriteLine(dog1.GetType().Name);
            Console.WriteLine(dog1.DoSound());
            Console.WriteLine(dog1.Stats());

            Bird bird1 = new Bird("Melow", 1, 2, "Crow");
            Console.WriteLine(bird1.GetType().Name);
            Console.WriteLine(bird1.DoSound());
            Console.WriteLine(bird1.Stats());

            Pelican bird2 = new Pelican("Pelicano", 2, 1, "Two", "Pink");
            Console.WriteLine(bird2.GetType().Name);
            Console.WriteLine(bird2.DoSound());
            Console.WriteLine(bird2.Stats());

            Wolf wolf1 = new Wolf("Alaskan Wolf", 25, 5, "Very long ears");
            Console.WriteLine(bird2.GetType().Name);
            Console.WriteLine(bird2.DoSound());
            Console.WriteLine(bird2.Stats());

            // Part 3.3: Create a list of the animal, and the reason that the elements in the list are of specific type. 
            // the only thing it accepts is animals objects. all these objects inherit form the animal class
            // This is the power of polymorphism and inheritance that all of these separate objects can be treated 
            // the same way as they are created from the same class animal.

            List<Animal> animals = new List<Animal>();
            animals.Add(horse1);
            animals.Add(dog1);
            animals.Add(bird1);
            animals.Add(bird2);
            animals.Add(wolf1);
            // declating and insgtatiating the object
            animals.Add(new Wolfman("Swedish", 20, 2, "Pointed"));

            foreach (var animal in animals)
            {
                System.Console.WriteLine("Animal name: {0}", animal, "Animal sound: {1}", animal.DoSound());
                System.Console.WriteLine("Animal sound: {0}", animal.DoSound());
                System.Console.WriteLine("Animal sound: {0}", animal.Stats());

                if (animal is Dog)
                {
                    // all animals are animals and some aniamals are dog
                    // new variable and type casting the varaible to dog
                    var dog = (Dog)animal;
                    Console.WriteLine(dog.DogMethod());
                }
                if (animal is IPerson)
                {
                    // we are iterating through the list and if an animal is impleemtning IPerson 
                    // then we know that this this manimal is implemeting the talk method
                    var myperson = (IPerson)animal;
                    Console.WriteLine(myperson.Talk());
                }
            }

            List<UserError> userErrors = new List<UserError>
            { 
                 // instatiantion the objects in the curly brakets
                new NumericInputError(),
                new TextInputError()
            };
            foreach (var message in userErrors)
            {
                Console.WriteLine(message.UEMessage());
            }
        }
    }
}
