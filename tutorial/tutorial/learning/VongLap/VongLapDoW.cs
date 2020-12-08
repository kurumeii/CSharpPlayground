using System;

namespace tutorial.learning.VongLap
{
    class VongLapDoW
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do While example");
            int x = 2;

            do
            {
                Console.WriteLine("Value of {0}", x);
                x += 3;
            }
            while (x < 10);
            Console.ReadLine();
        }
    }
}
