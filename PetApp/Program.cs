using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    // Class: Program
    // Author: Diya Iyer
    // Purpose: Hosts the main method
    // Restrictions: None
    internal class Program
    {
        // Method: Main()
        // Purpose: Creating various objects based on the pets and generating a scenario where the user adopts them
        // Restrictions: None
        static void Main(string[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();
            Random rand = new Random();

            string sName;
            string sAge;
            int nAge;
            string sLicense;

            // the main for loop that the entire simulation consists of 
            for (int i = 0; i < 50; i++) 
            {
                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    sName = "";
                    sAge = "";
                    nAge = 0;
                    sLicense = "";
                    // buying a dog
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("You bought a dog!");

                        // validating user input
                        do
                        {
                            Console.WriteLine("Dog's Name: ");
                            sName = Console.ReadLine();
                        } while (sName.Length == 0);

                        do
                        {
                            Console.WriteLine("Dog's Age: ");
                            sAge = Console.ReadLine();

                            // parsing so the age is an integer
                            if (!int.TryParse(sAge, out nAge))
                            {
                                Console.WriteLine("The given input must be a number");
                            }
                            else
                            {
                                break;
                            }
                        } while (true);

                        do
                        {
                            Console.WriteLine("License: ");
                            sLicense = Console.ReadLine();

                        } while (sLicense.Length == 0);

                        // adding dog to the pet list
                        dog = new Dog(sLicense, sName, nAge);
                        dog.Name = sName;
                        pets.Add(dog);
                    }
                    // buying a cat
                    else
                    {
                        Console.WriteLine("You bought a cat!");
                        // validating user input
                        do
                        {
                            Console.WriteLine("Cat's Name: ");
                            sName = Console.ReadLine();
                        } while (sName.Length == 0);

                        // parsing so the age is an integer
                        do
                        {
                            Console.WriteLine("Cat's Age: ");
                            sAge = Console.ReadLine();

                            if (!int.TryParse(sAge, out nAge))
                            {
                                Console.WriteLine("The given input must be a number");
                            }
                            else
                            {
                                break;
                            }
                        } while (true);

                        // adding the new cat to the pet list
                        cat = new Cat(); // empty constructor, have to set name and age outside 
                        cat.Name = sName;
                        cat.age = nAge;
                        pets.Add(cat);

                    }
                }
                else
                {
                    // choosing a random animal from the list
                    int petIndex = rand.Next(0, pets.Count);
                    thisPet = pets[petIndex];
                    if (thisPet == null)
                    {
                        // going back to the for loop
                        continue;
                    }
                    else
                    {
                        // picking a random activity
                        int activity = rand.Next(0, 5);
                        // cases if the chosen animal is a dog
                        if (thisPet.GetType().Equals(typeof(Dog))) 
                        {
                            iDog = (Dog)thisPet;
                            if (activity == 0) 
                            {
                                iDog.Eat();
                            }
                            else if (activity == 1)
                            {
                                iDog.Play();
                            }
                            else if (activity == 2)
                            {
                                iDog.Bark();
                            }
                            else if (activity == 3 )
                            {
                                iDog.NeedWalk();
                            }
                            else if (activity == 4)
                            {
                                iDog.GotoVet();
                            }
                        }
                        // if the chosen animal is a cat
                        else if (thisPet.GetType().Equals(typeof(Cat)))
                        {
                            iCat = (Cat)thisPet;

                            if (activity == 0)
                            {
                                iCat.Eat();
                            }
                            else if (activity == 1)
                            {
                                iCat.Play();
                            }
                            else if (activity == 2)
                            {
                                iCat.Purr();
                            }
                            else if (activity == 3)
                            {
                                iCat.Scratch();
                            }
                            else
                            {
                                iCat.Play();
                            }
                        }
                    }
                }

            }
        }
    }

    // Interface: ICat
    // The activities that the cat engages in
    public interface ICat
    {
        void Eat();
        void Play();
        void Scratch();
        void Purr();
        
    }

    // Class: Pet
    // Author: Diya Iyer
    // Purpose: Creates the name and age properties for pets, as well as the basic activities such as eat, play and going to the vet
    // Restrictions: None
    public abstract class Pet
    {
        private string name;
        public int age;
        public string Name;
        // default constructor
        public Pet()
        {

        }
        // intializing the name and age properties
        public Pet(string name, int age) 
        {
            this.name = name;
            this.age = age;

        }
        
        public abstract void Eat();
        public abstract void Play();
        public abstract void GotoVet();

    }

    // Class: Cat
    // Author: Diya Iyer
    // Purpose: Lists specific responses to the given activities 
    // Restrictions: None
    public class Cat : Pet, ICat
    {
        // default constructor 
        public Cat()
        {

        }

        // various response statements based on the activity 
       public override void Eat()
        {
            Console.WriteLine(this.Name + ": Make sure to add more fish next time...");
        }

        public override void Play()
        {
            Console.WriteLine(this.Name + ": I'll catch that red dot next time!");
        }

        public void Purr()
        {
            Console.WriteLine(this.Name + ": Purrrrrr! ");
        }

        public void Scratch()
        {
            Console.WriteLine(this.Name + ": Hiss! Don't get too close!");
        }

        public override void GotoVet()
        {
            Console.WriteLine(this.Name + ": Meow...I don't want to go to the vet!");
        }
    }

    //Interface: IDog
    // The activities the dog engages in
    public interface IDog
    {
        void Eat();
        void Play();
        void Bark();
        void NeedWalk();
        void GotoVet();
    }

    // Class: Dog
    // Author: Diya Iyer
    // Purpose: Lists specific responses to the given activities 
    // Restrictions: None
    public class Dog : Pet, IDog
    {
        public string license;
        // constructor includes the additional license, name and age taken from parent Pet class
        public Dog(string szLicense, string szName, int nAge) : base(szName, nAge)
        {
            this.license = szLicense;
        }
        // various response statements based on the activity 
        public override void Eat()
        {
            Console.WriteLine(this.Name + ": Woof! Any leftovers for me?");
        }

        public override void Play()
        {
            Console.WriteLine(this.Name + ": Throw the ball! Throw the ball!");
        }

        public void Bark()
        {
            Console.WriteLine(this.Name + ": Arooo! Bark bark!");
        }

        public void NeedWalk()
        {
            Console.WriteLine(this.Name + ": Don't just sit there! Let's go for a walk!");
        }

        public override void GotoVet()
        {
            Console.WriteLine(this.Name + ": Oh no! It's time to hide, I'm afraid of needles!");
        }
    }

    // Class: Cat
    // Author: Diya Iyer
    // Purpose: Hosts the list of pets that the owner has
    // Restrictions: None
    public class Pets
    {
        List<Pet> petList = new List<Pet>();
        // getting the count from petList
        public int Count { get { return petList.Count; } }

        // adding to the list
        public void Add (Pet pet)
        {
            petList.Add(pet);
        }

        // removing from the list
        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }

        // removing at the specified index
        public void RemoveAt(int petEl)
        {
            petList.RemoveAt(petEl);
        }
        // given code
        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }
        }

    }

}
