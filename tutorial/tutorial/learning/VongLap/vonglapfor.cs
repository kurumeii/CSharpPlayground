using System;

namespace tutorial.learning.VongLap
{
    class Vonglapfor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For loop example");

            for (int i = 2; i < 15; i += 3)
            {
                Console.WriteLine();
                Console.WriteLine("Value of x = {0}", i);
            }

            Console.ReadLine();
        }
    }
}
