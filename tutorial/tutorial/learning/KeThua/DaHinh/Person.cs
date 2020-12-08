using System;

namespace tutorial.learning.KeThua.DaHinh
{
    class Person
    {
        // Trường name - thông tin tên người
        public String Name;

        // Trường bornYear - thông tin năm sinh
        public int BornYear;

        // Nơi sinh
        public String PlaceOfBirth;

        // Constructor  này có 3 tham số. 
        // Mục đích để khởi tạo các giá trị cho các trường của Person.
        // Chỉ định rõ tên, năm sinh, nơi sinh.
        public Person(String Name, int BornYear, String PlaceOfBirth)
        {
            this.Name = Name;
            this.BornYear = BornYear;
            this.PlaceOfBirth = PlaceOfBirth;
        }

        // Constructor này có 2 tham số. 
        // Mục đích khởi tạo giá trị cho 2 trường tên và năm sinh cho Person.
        // Nơi sinh không được khởi tạo.
        public Person(String Name, int BornYear)
        {
            this.Name = Name;
            this.BornYear = BornYear;
        }
    }
}
