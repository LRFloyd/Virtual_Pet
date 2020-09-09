using System;

namespace Virtual_Pet
{
    public class VirtualPet
    {

        //class fields 
        protected string petName;
        protected string animalType;
        protected int petHunger = 5;
        protected int petThirst = 3;
        protected int petWaste = 0;
        protected bool petSleep = false;
        protected bool isAlive = true;
        protected string petBoredom = "Happy";

        //class properties
        
        public string PetName
        {
            get { return this.petName; }
            set { this.petName = value; }
        }
        private string AnimalType
        {
            get { return animalType; }
            set { animalType = value; }
        }

        public int PetHunger
        {
            get { return this.petHunger; }
            set { this.petHunger = value; }
        }

        protected int PetThirst
        {
            get { return petThirst; }
            set { petThirst = value; }
        }

        public int PetWaste
        {
            get { return petWaste; }
            set { petWaste = value; }
        }

        public bool PetSleep
        {
            get { return petSleep; }
            set { petSleep = value; }
        }
        
        public bool IsAlive { get; set; }

        public string PetBoredom
        {
            get { return this.petBoredom; }
            set { this.petBoredom = value; }
        }

        //class constructors
        public VirtualPet()
        {
           //default constructor
        }

        public VirtualPet(string petName, string animalType, int petHunger, int petThirst, bool petSleep, int petWaste, string petBoredom, bool isAlive)
        {
            this.petName = petName;
            this.animalType = animalType;
            this.petHunger = petHunger;
            this.petThirst = petThirst;
            this.petSleep = petSleep;
            this.petWaste = petWaste;
            this.petBoredom = petBoredom;
            this.isAlive = isAlive;
        }

        //class methods
        public void PetFeed()
        {
            Console.WriteLine("What would you like to feed your pet? Please select one of the following numbers");
            Console.WriteLine("\n1.)meal" + "\n2.)snack" + "\n3.)diet");
            int food = 0;
            if (Console.ReadLine() == "")
            {
                food.ToString();
            }
            else
            {
                food = int.Parse(Console.ReadLine());
            }
            switch (food)
            {
                case 1:
                    PetHunger = 5;
                    PetThirst -= 2;
                    PetWaste = 3;
                    Console.WriteLine("Your pet is now full");
                    break;

                case 2:
                    PetHunger += 2;
                    PetThirst -= 1;
                    PetWaste += 1;
                    Console.WriteLine("Your pet is now satisfied");
                    break;

                case 3:
                    PetHunger += 1;
                    PetThirst -= 1;
                    PetBoredom = "Mad";
                    Console.WriteLine("Your pet was feed but is annoyed");
                    break;

                default:
                    Console.WriteLine("I thought you said you wanted to feed your pet");
                    PetHunger -= 3;
                    PetThirst -= 3;
                    PetWaste += 3;
                    break;
            }
            Console.Clear();
        }

        public string SelectAnimal(string reply)
        {            
            switch (reply)
                {
                    case "CAT":
                        Console.WriteLine("You choose a Cat");
                        break;
                    case "DOG":
                            Console.WriteLine("You choose a Dog");
                            break;
                    case "BIRD":
                        Console.WriteLine("You choose a Bird");
                        break;
                    case "FISH":
                        Console.WriteLine("You choose a Fish");
                        break;
                    default:
                        break;
                }
            AnimalType = reply;
             return reply;
        }
        
        public void Mood()
        {
            //add things


        }

        public void Tick()
        {
            petWaste += 1;
            petThirst -= 1;
            petHunger += 1;
        }

        public void Death()
        {
            if (isAlive)
            {
                isAlive = false;
            }
        }

        public void UI()
        {
            Console.WriteLine("Name: " + petName);
            Console.WriteLine("Pet Type: " + animalType );
            switch (animalType)
            {
                case "CAT":
                    CatAscii();
                    break;
                case "DOG":
                    DogAscii();
                    break;
                case "BIRD":
                    BirdAscii();
                    break;
                case "FISH":
                    FishAscii();
                    break;
                default:
                    break;
            }
            Console.WriteLine("Hunger Level: " + petHunger );
            Console.WriteLine("Thirst Level: " + petThirst );
            Console.WriteLine("Waste Level: " + petWaste);
            Console.WriteLine("Pet Mood: " + petBoredom);
        }

        protected void CatAscii()
        {
            Console.WriteLine(@" /\_/\ ");
            Console.WriteLine(@"( o.o )");
            Console.WriteLine(@" > ^ <");
        }

        protected void DogAscii()
        {
            Console.WriteLine(@" ,-.___,-.");
            Console.WriteLine(@" \_)O_O(_/");
            Console.WriteLine(@"  { (_) }");
        }

        protected void BirdAscii()
        {
            Console.WriteLine(@" ^ ^ ");
            Console.WriteLine(@"(O,O)");
            Console.WriteLine(@"(|..|)");
        }

        protected void FishAscii()
        {
            Console.WriteLine(@"   _\_   o");
            Console.WriteLine(@"\\/  o\ . O");
            Console.WriteLine(@"//\___=");
        }


    }
}
