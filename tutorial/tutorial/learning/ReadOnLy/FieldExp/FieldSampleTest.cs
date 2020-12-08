using System;


namespace ReadOnly.FieldExp
{
    class FieldSampleTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("my static value = {0}", FieldSample.My_static_field);
            FieldSample.My_static_field = 404;
            Console.WriteLine("---------------");

            FieldSample obj1 = new FieldSample("value1");
            Console.WriteLine("obj1 value = " + obj1.MyValue);

            // Tạo đối tượng thứ 2:
            FieldSample obj2 = new FieldSample("Value2");


            Console.WriteLine("obj2 Value = {0}", obj2.MyValue);

            // Bạn có thể thay đổi giá trị của trường.
            obj2.MyValue = "Value2-2";

            Console.ReadLine();
        }
    }
}
