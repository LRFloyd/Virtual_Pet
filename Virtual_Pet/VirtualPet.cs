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
        protected string petMood = "Happy";

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

        protected int PetHunger
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

        public string PetMood
        {
            get { return this.petMood; }
            set { this.petMood = value; }
        }

        //class constructors
        public VirtualPet()
        {
           //default constructor
        }

        public VirtualPet(string petName, string animalType, int petHunger, int petThirst, bool petSleep, int petWaste, string petMood, bool isAlive)
        {
            this.petName = petName;
            this.animalType = animalType;
            this.petHunger = petHunger;
            this.petThirst = petThirst;
            this.petSleep = petSleep;
            this.petWaste = petWaste;
            this.petMood = petMood;
            this.isAlive = isAlive;
        }

        //class methods
        public void PetFeed() //method used to feed the pet
        {
            Console.WriteLine("What would you like to feed your pet? Please select one of the following numbers");
            Console.WriteLine("\n1.)meal" + "\n2.)snack" + "\n3.)diet");
            int food = 0;
            //checking user input before passing food variable to switch case
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
                    PetMood = "Mad";
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

        public void PetDrink()
        {
            Console.WriteLine("What would you like to feed your pet? Please select one of the following numbers");
            Console.WriteLine("\n1.)water"  + "\n2.)bubbly");
            int drink = 0;
            //checking user input before passing food variable to switch case
            if (Console.ReadLine() == "")
            {
                drink.ToString();
            }
            else
            {
                drink = int.Parse(Console.ReadLine());
            }
            
            switch (drink)
            {
                case 1:
                    PetHunger += 1;
                    PetThirst -= 2;
                    PetWaste = 3;
                    Console.WriteLine("Your pet is now full");
                    break;

                case 2:
                    PetHunger += 1;
                    PetThirst -= 2;
                    PetWaste += 1;
                    Console.WriteLine("Your pet is now under the influence");
                    break;

                default:
                    Console.WriteLine("I thought you said you wanted to give  your pet a drink");
                    PetHunger -= 3;
                    PetThirst -= 3;
                    PetWaste += 3;
                    break;
            }
            Console.Clear();
        }

        public string SelectAnimal(string reply)//method used to display animal type also will help to print ascii art
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
            if ((PetHunger >= 2) && (PetThirst >= 2))
            {
                PetMood = "Happy";
            }
            else if ((PetHunger <= 1) && (PetThirst <= 1))
            {
                PetMood = "Annoyed";
            }
            else if ((PetMood == "Annoyed") && (PetHunger <= 0))
            {
                
            }
        }

        public void Tick()
        {
            petWaste += 1;
            petThirst -= 1;
            petHunger += 1;
        }

        public void Death()//animal death method
        {
            if (isAlive)
            {
                isAlive = false;
            }
        }

        public void UI()//animal UI
        {
            Console.WriteLine("Name: " + petName);
            Console.WriteLine("Pet Type: " + animalType );
            switch (animalType)//checks the animal type then calls the method respectively
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

        //animal ascii art methods
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
