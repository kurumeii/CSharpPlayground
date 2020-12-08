using System;

namespace tutorial.learning.Whilecondition
{
    class WhileBreak2
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Input some number from 1 to 3: \n");
            string input = Console.ReadLine();

            option = Int32.Parse(input);
            // Kiểm tra giá trị của 'option'.
            switch (option)
            {

                case 1:
                    Console.WriteLine("Case 1");
                    break;

                // Trường hợp option = 2,3,4,5 xử lý giống nhau.   
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Case 2,3,4,5!!!");
                    break;
                default:
                    Console.WriteLine("Nothing to do...");
                    break;
            }
        }
    }
}
