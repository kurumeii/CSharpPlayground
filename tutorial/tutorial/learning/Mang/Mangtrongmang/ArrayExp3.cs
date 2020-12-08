using System;

namespace Mang.Mangtrongmang
{
    class ArrayExp3
    {
        static void Main(string[] args)
        {
            //khai bao mang 3 phan tu, moi phan tu la 1 mang
            string[][] teams = new string[4][];

            string[] Manu =
            {
                "Bruno Fernandes", "Edinson Cavani", "Paul Pogba"
            };

            string[] Barca =
            {
                "Antoine Grizemann", "Frankie De Jong", "Leo Messi"
            };

            string[] Juventus =
            {
                "Cristiano Ronaldo", "Paulo Dybala", "Juan Cuadrado"
            };

            string[] AcMillan =
           {
                "Zlatan Ibrahimovic", "Hakan Çalhanoğlu", "Theo Hernández"
            };

            teams[0] = Manu;
            teams[1] = Barca;
            teams[2] = Juventus;
            teams[3] = AcMillan;

            for (int row = 0; row < teams.Length; row++)
            {
                for (int col = 0; col < teams[row].Length; col++)
                {
                    Console.WriteLine("Ele at [{0},{1}] ={2}", row, col, teams[row][col]);
                }
                Console.WriteLine("---------------------");
            }
            Console.ReadLine();
        }
    }
}