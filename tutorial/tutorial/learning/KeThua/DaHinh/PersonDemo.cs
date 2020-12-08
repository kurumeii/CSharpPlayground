using System;

namespace tutorial.learning.KeThua.DaHinh
{
    class PersonDemo
    {
        static void Main(string[] args)
        {

            // Đối tượng: Thomas Edison.
            // Được tạo ra bởi Constructor có 2 tham số của lớp Person.
            Person edison = new Person("Thomas Edison", 1847);

            Console.WriteLine("Info:");
            Console.WriteLine("Name: " + edison.Name);
            Console.WriteLine("Born Year: " + edison.BornYear);
            Console.WriteLine("Place Of Birth: " + edison.PlaceOfBirth);

            // Đối tượng: Bill Gates
            // Được tạo ra bởi Constructor có 3 tham số của lớp Person.
            Person billGates = new Person("Bill Gate", 1955, "Seattle, Washington");

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Info:");
            Console.WriteLine("Name: " + billGates.Name);
            Console.WriteLine("Born Year: " + billGates.BornYear);
            Console.WriteLine("Place Of Birth: " + billGates.PlaceOfBirth);

            Console.ReadLine();
        }
    }
}
