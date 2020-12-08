using System;

namespace tutorial.learning.Mang
{
    class ArrayExp1
    {
        static void Main(string[] args)
        {
            //Cách 1:
            int[] stt = { 1, 2, 3, 4 };
            Console.WriteLine("STT = {0} \n", stt.Length);
            for (int i = 0; i < stt.Length; i++)
            {
                Console.WriteLine("STT {0} = {1}", i, stt[i]);
            }
            //Cách 2:
            int[] lương = new int[3];
            lương[0] = 1000;
            lương[1] = 2000;
            lương[2] = 3000;
            Console.WriteLine("Lương = {0} \n", lương.Length);
            for (int i = 0; i < lương.Length; i++)
            {
                Console.WriteLine("Lương {0} = {1}", i, lương[i]);
            }
            Console.ReadLine();
        }
    }
}
