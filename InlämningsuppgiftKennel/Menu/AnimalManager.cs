using InlämningsuppgiftKennel.Customers;
using InlämningsuppgiftKennel.Data;
using InlämningsuppgiftKennel.Dog;
using InlämningsuppgiftKennel.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace InlämningsuppgiftKennel.Menu
{
    public class AnimalManager : IAnimalManager
    {
        IAnimalFactory AnimalFactory;

        IDataRepository Db;

        public AnimalManager(IAnimalFactory animalFactory, IDataRepository db)
        {
            AnimalFactory = animalFactory;
            Db = db;

        }
        public void RegisterAnimal()
        {
            IAnimal animal = AnimalFactory.Create();

            //TODO: Add Validation
            Console.WriteLine(value: "Please enter your dogs name:  ");
            animal.DogName = Console.ReadLine();

            //TODO: Add Validation
            Console.WriteLine(value: "Please enter the owners name:  ");
            animal.OwnerName = Console.ReadLine();

            Db.AddAnimalToDb(animal);
        }

        public void CheckInAnimal()
        {
            var animals = Db.GetAllAnimals();
            for(int i = 0; i < animals.Count; i++)
            {
                if (!animals[i].IsCheckedIn)
                {
                    Console.WriteLine($"{i}   {animals[i].DogName}");
                }
            }
            Console.WriteLine("Select the animal you want to check in");
            int chosenAnimal = Convert.ToInt32(Console.ReadLine());
            animals[chosenAnimal].IsCheckedIn = true;
            Console.ReadLine();
        }
        public void CheckOutAnimal()
        {
            var animals = Db.GetAllAnimals();
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].IsCheckedIn)
                {
                    Console.WriteLine($"{i}   {animals[i].DogName}");
                }
            }
            Console.WriteLine("Select the animal you want to check out");
            int chosenAnimal = Convert.ToInt32(Console.ReadLine());
            animals[chosenAnimal].IsCheckedIn = false;
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("---- Reciept ----");
            Console.WriteLine("1day-pass at kennel: 700:-");
            if (animals[chosenAnimal].GotClawcut)
            {
                Console.WriteLine("Got a claw cut: 300:-");
            }
            if (animals[chosenAnimal].GotHaircut)
            {
                Console.WriteLine("Got a claw cut: 500:-");
            }
            Console.WriteLine($"Total Price: {animals[chosenAnimal].Price}:-");
            Console.ReadLine();
            Console.Clear();
        }

        public void ViewRegisteredAnimals()
        {
            var animals = Db.GetAllAnimals();
            foreach (var animal in animals)
            {
                Console.WriteLine("Dog name & Owner name: ");
                Console.WriteLine(animal.DogName);
                Console.WriteLine("--------------");
                Console.WriteLine(animal.OwnerName);
            }
            Console.ReadLine();
        }

        public void ListCheckedInAnimals()
        {
            foreach (var animal in Db.GetAllAnimals())
            {
                if (animal.IsCheckedIn)
                {
                    Console.WriteLine("Dog name: ");
                    Console.WriteLine(animal.DogName);
                    Console.WriteLine("And their Owners name is: ");
                    Console.WriteLine(animal.OwnerName);
                }
            }
            Console.ReadLine();
        }

        public void AddHaircut()
        {
            var animals = Db.GetAllAnimals();
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].IsCheckedIn)
                {
                    Console.WriteLine($"{i}   {animals[i].DogName}");
                }
            }
            Console.WriteLine("Select the animal you want to cut hair");
            int chosenAnimal = Convert.ToInt32(Console.ReadLine());
            animals[chosenAnimal].GotHaircut = true;
            animals[chosenAnimal].Price += 500;
            Console.ReadLine();
            Console.Clear();
        }

        public void AddClawcut()
        {
            var animals = Db.GetAllAnimals();
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].IsCheckedIn)
                {
                    Console.WriteLine($"{i}   {animals[i].DogName}");
                }
            }
            Console.WriteLine("Select the animal you want to cut claws");
            int chosenAnimal = Convert.ToInt32(Console.ReadLine());
            animals[chosenAnimal].GotClawcut = true;
            animals[chosenAnimal].Price += 300;
            Console.ReadLine();
            Console.Clear();
        }
    }
}
