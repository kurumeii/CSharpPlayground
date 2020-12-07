using System;

namespace Whilecondition

{
    internal class WhileBreak
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Please select an option: ");
            Console.WriteLine("1. play a game \n");
            Console.WriteLine("2. play music \n");
            Console.WriteLine("3. exit this shit \n");

            int option;
            string input = Console.ReadLine();

            option = Int32.Parse(input);

            switch (option)
            {
                case 1:
                    Console.WriteLine("you chose to play a game");
                    break;

                case 2:
                    Console.WriteLine("Music it is, a very wise choice");
                    break;

                case 3:
                    Console.WriteLine("aight bueno dias master");
                    break;
            }
            Console.ReadLine();
        }
    }
}