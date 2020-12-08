using System;

namespace Mang2chieu
{
    class ArrayExp2
    {
        static void Main(string[] args)
        {
            //Khai báo mảng 2 chiều, 3 row, 4 col và gán giá trị
            int[,] a =
            {
                { 1, 2, 3, 4},
                { 5, 6, 7, 8},
                { 9, 10, 11, 12}
            };

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.WriteLine("Ele at [{0}, {1}] = {2}", row, col, a[row, col]);
                }
            }
            //không gán giá trị
            int[,] b = new int[3, 4];
            Console.WriteLine();
        }
    }
}
