using System.Runtime.Versioning;

namespace wizards
{
    class Program
    {
        enum MagicTypes
        {
            Fire,
            Water,
            Earth,
            Grass,
            Neutral,
        };
        [SupportedOSPlatform("windows")]
        static void Main(string[] args)
        {
            // Change console settings
            Console.Title = "Grand Wizard Tournament";
            Console.WindowHeight = 40;
            // NPC Dialog
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello there challenger!\nWelcome to the GRAND WIZARD TOURNAMENT!\n");
            Console.WriteLine("What might your name be?");
            // Wait for user response
            Console.ForegroundColor = ConsoleColor.Red;
            string name = Console.ReadLine() ?? string.Empty;
            // NPC Dialog
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nSo your name is " + name + "? Hmmm... never heard of you.\nI hope you know what you're getting yourself into.\n");

            // NPC Dialog
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nWhat's your magic type?\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n1. Fire\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n2. Water\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n3. Earth\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n4. Grass\n");
            // User Instruction
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nChoose your magic style by entering a number between 1-4.\n");

            MagicTypes chosenType = MagicTypes.Neutral;
            int choice;
            bool chosen = false;
            while (!chosen)
            {
                // Wait for user response
                Console.ForegroundColor = ConsoleColor.Red;
                choice = Convert.ToInt32(Console.ReadLine() ?? string.Empty);
                // NPC Dialog
                Console.ForegroundColor = ConsoleColor.Yellow;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nSo you're a Fire type ay?\n");
                        chosenType = MagicTypes.Fire;
                        chosen = true;
                        break;
                    case 2:
                        Console.WriteLine("\nSo you're a Water type ay?\n");
                        chosenType = MagicTypes.Water;
                        chosen = true;
                        break;
                    case 3:
                        Console.WriteLine("\nSo you're a Earth type ay?\n");
                        chosenType = MagicTypes.Earth;
                        chosen = true;
                        break;
                    case 4:
                        Console.WriteLine("\nSo you're a Grass type ay?\n");
                        chosenType = MagicTypes.Grass;
                        chosen = true;
                        break;
                    default:
                        Console.WriteLine("\nThat's not a choice, try again.\n");
                        break;
                };
            };
            Console.WriteLine("\nPssh... I hate " + chosenType + " types...\nAlright, get ready " + name + ".\nThe tournament is about to start...\n");

            // Wait for user input
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to exit the tournament.");
            Console.ReadKey();
        }
    }
}

