using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial.learning.Method.Example1
{
    class MethodSampleTest
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng MethodSample
            MethodSample obj = new MethodSample();

            // Gọi phương thức GetText()
            // Các phương thức không tĩnh cần phải được gọi thông qua đối tượng. 
            String text = obj.GetText();

            Console.WriteLine("Text = " + text);

            // Gọi phương thức SetText(string)
            // Các phương thức không tĩnh cần phải được gọi thông qua đối tượng.            
            obj.SetText("New Text");

            Console.WriteLine("Text = " + obj.GetText());

            // Các phương thức tĩnh cần phải được gọi thông qua tên lớp. 
            int sum = MethodSample.Sum(10, 20, 30);

            Console.WriteLine("Sum  10,20,30= " + sum);

            Console.ReadLine();
        }
    }
}
