using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial.learning.KeThua.Example1
{
    class Cat : Animal
    {
        public void Say()
        {
            Console.WriteLine("Nyan~");
        }

       public void FavFood()
        {
            Console.WriteLine("Fish");
        }
    }
}
