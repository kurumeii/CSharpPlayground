using System;

namespace Class_n_Cons.Example1
{
    class PersonTest
    {
        static void Main(string[] args)
        {
            Person gooruh = new Person("Gawr Gura");

            Console.WriteLine("Person 1: {0}", gooruh.GetName());

            Person groundpnd = new Person("Amelia Watson");

            Console.WriteLine("Person 2: {0}", groundpnd.GetName());

            Console.ReadLine();
        }
    }
}
