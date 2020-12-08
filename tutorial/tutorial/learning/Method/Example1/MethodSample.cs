using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial.learning.Method.Example1
{
    class MethodSample
    {
        public string text = "Some text";

        // Một Constructor mặc định.
        // Nghĩa là Constructor không có tham số.
        public MethodSample()
        {

        }

        // Đây là một phương thức trả về kiểu String.
        // Phương thức này không có tham số.
        public string GetText()
        {
            return this.text;
        }
        // Đây là một phương thức có 1 tham số String.
        // Phương thức này trả về void (Hay gọi là ko trả về gì)
        public void SetText(string text)
        {
            // this.text: tham chiếu tới trường text.
            // Để phân biệt với tham số text.
            this.text = text;
        }

        // Đây là một phương thức tĩnh.
        // Trả về kiểu int, và có 3 tham số.
        public static int Sum(int a, int b, int c)
        {
            int d = a + b + c;
            return d;
        }
    }
}
