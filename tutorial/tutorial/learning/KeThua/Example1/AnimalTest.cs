using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial.learning.KeThua.Example1
{
    class AnimalTest
    {
        static void Main(string[] args)
        {
            //Khai báo 1 đối tượng Cat
            Cat gooruh = new Cat();

            gooruh.Say();
            gooruh.FavFood();

            //Khai bao doi tuong dog
            Dog booba = new Dog();

            booba.Move();
            booba.Say();
            booba.FavFood();

            Console.ReadLine();
        }
    }
}
