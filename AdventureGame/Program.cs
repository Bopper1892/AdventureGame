using System;
using System.Globalization;

namespace AdventureGame
{
    class Program
    {
        static void Main()
        {
            string characterName = "Wizard";
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            Console.WriteLine("Flynn's Amazing Adventure Game!");
            Console.WriteLine("Welcome to my magical world of fun!\n");
            Console.WriteLine("OK, let's get started by setting up your character.");
            //Capture user name choice
            Console.Write("Enter a name for your character: ");
            characterName = Console.ReadLine();
            Console.WriteLine("{1}", characterName, myTI.ToTitleCase(characterName) + "! What a cool name!\n");
            Console.ReadLine();
        }


    }
}
