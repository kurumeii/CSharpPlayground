using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial.learning.KeThua.Example1
{
    class Dog : Animal
    {
        public void Say()
        {
            Console.WriteLine("woof");
        }

        public void FavFood()
        {
            Console.WriteLine("Snack");
        }
    }
}
