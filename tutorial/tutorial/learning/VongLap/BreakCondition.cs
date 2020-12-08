using System;

namespace tutorial1.learning.VongLap
{
    class BreakCondition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Break example");

            // Tạo một biến x và gán giá trị 2 cho nó.
            int x = 2;

            while (x < 15)
            {

                Console.WriteLine("----------------------\n");
                Console.WriteLine("x = {0}", x);

                // Kiểm tra nếu x = 5 thì thoát ra khỏi vòng lặp.
                if (x == 5)
                {
                    break;
                }
                // Tăng giá trị của x lên 1 (Viết ngắn gọn cho x = x + 1;).
                x++;
                Console.WriteLine("x after ++ = {0}", x);
            }
            Console.ReadLine();
        }
    }
}
