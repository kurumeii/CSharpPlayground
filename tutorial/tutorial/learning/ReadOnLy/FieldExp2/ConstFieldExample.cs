using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial.learning.ReadOnLy.FieldExp2
{
    class ConstFieldExample
    {
        // Một trường hằng số, giá trị của nó được xác định tại thời điểm biên dịch.
        // Bạn không thể gán giá trị mới cho các trường const.
        // Chú ý: Trường const luôn luôn là static (Tĩnh).
        public const int MY_VALUE = 100;

        // Một trường tĩnh (static field) và readonly. 
        // Giá trị của nó có thể gán sẵn, hoặc chỉ được gán 1 lần trong Constructor.
        public static readonly DateTime INIT_DATE_TIME1 = DateTime.Now;

        // Một trường readonly và không tĩnh (none-static)
        // Giá trị của nó có thể gán sẵn, hoặc chỉ được gán một lần trong Constructor.
        public readonly DateTime INIT_DATE_TIME2;

        public ConstFieldExample()
        {
            // Giá trị của nó được gán 1 lần, tại lần chạy đầu tiên.
            INIT_DATE_TIME2 = DateTime.Now;
        }
    }
}
