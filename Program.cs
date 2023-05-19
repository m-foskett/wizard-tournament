using System.Runtime.Versioning;

namespace wizards
{
    class Program
    {
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
            var name = Convert.ToString(Console.ReadLine());
            // NPC Dialog
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nSo your name is " + name + "? Hmmm... never heard of you.\nI hope you know what you're getting yourself into.\n");
            // Wait for user input
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to exit the tournament.");
            Console.ReadKey();
        }
    }
}

