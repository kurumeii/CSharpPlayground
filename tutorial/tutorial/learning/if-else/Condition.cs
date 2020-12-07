using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial1.learning.if_else
{
    class Condition 
    {
        static void Main(string[] args)
        {
            // Khai báo một số kiểu int, mô tả tuổi của bạn.


            Console.WriteLine("Please enter your age: ");

            // Khai báo một biến, để lưu trữ đoạn text người dùng nhập vào từ bàn phím. 
            string inputAge = Console.ReadLine();

            // Int32 là một lớp nằm trong namespace System.
            // Sử dụng phương thức tĩnh Parse của lớp Int32 để chuyển đổi một chuỗi thành một số
            // Và gán vào biến age.
            // (Chú ý: Nếu 'inputStr' không phải là chuỗi số, có thể gây lỗi chương trình tại đây).
            int age = Int32.Parse(inputAge);

            Console.WriteLine("Your age: {0} \n", age);

            if (age <= 18 && age >= 13)
            {
                Console.WriteLine("You are a teenager");
            }

            else if (age <= 12 && age >= 8)
            {
                Console.WriteLine("You are a child");
            }
            // Ngược lại (Các trường hợp còn lại)
            else if (age >= 20 && age <= 40)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You're old as fuck");
            }

            Console.ReadLine();
        }
    }
}
