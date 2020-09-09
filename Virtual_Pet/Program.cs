using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace Virtual_Pet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t" + @"   __      ___      _               _   _____     _   ");
            Console.WriteLine("\t" + @"   \ \    / (_)    | |             | | |  __ \   | |  ");
            Console.WriteLine("\t" + @"    \ \  / / _ _ __| |_ _   _  __ _| | | |__) |__| |_ ");
            Console.WriteLine("\t" + @"     \ \/ / | | '__| __| | | |/ _` | | |  ___/ _ \ __|");
            Console.WriteLine("\t" + @"      \  /  | | |  | |_| |_| | (_| | | | |  |  __/ |_ ");
            Console.WriteLine("\t" + @"       \/   |_|_|   \__|\__,_|\__,_|_| |_|   \___|\__|");
            Console.WriteLine("\t" +"Created By LRFloyd");
            Console.ReadKey();
            Console.Clear();

            //global variables

            bool petAlive = true;
            bool petExist = false;
            
            Console.WriteLine("Welcome to Virtual Pet");
            Console.WriteLine("You can press enter to continue the game, or type exit to quit");
            UserReply();
            Console.Clear();

            VirtualPet firstPet = new VirtualPet();
            Console.WriteLine("What is kind of animal do you have? \nAnimal types are the following. \nCat \nDog \nBird \nFish");
            string pet = firstPet.SelectAnimal(UserReply());
            Console.Clear();
            while (pet == "")
            {
                Console.WriteLine("Invalid entry. Please select an animal");
                Console.WriteLine("\nAnimal types are the following.\n\nCat \nDog \nBird \nFish");
                pet = firstPet.SelectAnimal(UserReply());
                Console.Clear();
            }

            Console.WriteLine("Great, and what about your pet Name");
            firstPet.PetName = UserReply();
            Console.Clear();
            while (firstPet.PetName == "")
            {
                Console.WriteLine("Invalid entry. Please enter a name.");
                firstPet.PetName = UserReply();
                Console.Clear();
            }

            petExist = true;
            Console.Clear();

            do
            {

               firstPet.UI();
                Console.WriteLine("\nWhat would you like to do with your pet. \nYou can select 1 of the following numbers to interact with your pet: \n1)Feed your Pet \n2)Give your Pet something to drink \n3)Allow your pet to use relieve itself. ");
                switch (UserReply())
                {
                    case "1":
                        Console.WriteLine("\nYou choose to feed your pet");
                        firstPet.PetFeed();
                        break;
                    case "2":
                        Console.WriteLine("You choose to give your pet something to drink");
                        firstPet.PetDrink();
                        break;
                    case "3":
                        Console.WriteLine("You choose to allow your pet to rid clear its bowels");
                        break;
                    default:
                        firstPet.Tick();
                        Console.Clear();
                        break;
                }

                if (!petAlive)
                {
                    firstPet.Death();
                    Console.WriteLine("You pet just died");
                    Console.WriteLine("Would you like to play again? If so type yes or type quit to leave");
                    UserReply();
                    Console.WriteLine("Okay, Lets restart");
                    Console.Clear();
                }

            }while (petExist == true);
        }
        
        static string UserReply()
        {
             string userInput = Console.ReadLine().ToUpper();
            if (userInput == "QUIT")
            {
                System.Environment.Exit(0);
            }
            return userInput;
        }
    }
}