using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Virtual Pet Simulator!");

        // Pet Creation
        Console.WriteLine("Choose your pet type (e.g., cat, dog, rabbit): ");
        string petType = Console.ReadLine();

        Console.WriteLine("Give your pet a name: ");
        string petName = Console.ReadLine();

        Pet myPet = new Pet(petName, petType);
        Console.WriteLine($"Welcome, {myPet.Name} the {myPet.Type}!");

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nChoose an action: ");
            Console.WriteLine("1. Feed your pet");
            Console.WriteLine("2. Play with your pet");
            Console.WriteLine("3. Let your pet rest");
            Console.WriteLine("4. Check your pet's status");
            Console.WriteLine("5. Pass time");
            Console.WriteLine("6. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    myPet.Feed();
                    break;
                case "2":
                    myPet.Play();
                    break;
                case "3":
                    myPet.Rest();
                    break;
                case "4":
                    myPet.DisplayStatus();
                    break;
                case "5":
                    myPet.PassTime();
                    Console.WriteLine("Time has passed.");
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }

            myPet.DisplayStatus();
        }

        Console.WriteLine("Thank you for playing the Virtual Pet Simulator!");
    }
}
