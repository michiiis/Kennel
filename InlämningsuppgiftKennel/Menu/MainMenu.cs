using InlämningsuppgiftKennel.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace InlämningsuppgiftKennel.Menu
{
    class MainMenu : IMainMenu
    {
        public ICustomerManager CustomerManager { get; set; }
        public IAnimalManager AnimalManager { get; set; }

        public MainMenu(ICustomerManager customerManager, IAnimalManager animalManager)
        {
            CustomerManager = customerManager;
            AnimalManager = animalManager;
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(value: "--- Kennel ---");
            Console.WriteLine(value: "Choose an option:");
            Console.WriteLine(value: "1) Register Customer");
            Console.WriteLine(value: "2) Register Animal");
            Console.WriteLine(value: "3) Check In Animal");
            Console.WriteLine(value: "4) Check Out Animal");
            Console.WriteLine(value: "5) List All Registered Animals And Their Owners");
            Console.WriteLine(value: "6) List All Registered Customers");
            Console.WriteLine(value: "7) List All Checked In Animals");
            Console.WriteLine(value: "8) Add Haircut");
            Console.WriteLine(value: "9) Add Clawcut");
        }

        public void GetInput()
        {
            var userInput = Console.ReadKey(intercept: true).Key;
            switch (userInput)
            {
                //Register Customer
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    CustomerManager.RegisterCustomer();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    // Register Animal
                    AnimalManager.RegisterAnimal();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    // Check in animal
                    AnimalManager.CheckInAnimal();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    // Check out animal
                    AnimalManager.CheckOutAnimal();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    // List all Animals
                    AnimalManager.ViewRegisteredAnimals();
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    // List all Customers
                    CustomerManager.ViewRegisteredCustomers();
                    break;
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    // List all Checked In Animals
                    AnimalManager.ListCheckedInAnimals();
                    break;
                case ConsoleKey.D8:
                case ConsoleKey.NumPad8:
                    // List all Checked In Animals
                    AnimalManager.AddHaircut();
                    break;
                case ConsoleKey.D9:
                case ConsoleKey.NumPad9:
                    // List all Checked In Animals
                    AnimalManager.AddClawcut();
                    break;
                default:
                    Console.WriteLine("Unknown Command");
                    ShowMenu();
                    break;
            }
        }
    }
}
