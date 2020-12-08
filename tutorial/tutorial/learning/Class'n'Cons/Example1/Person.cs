using System;
using System.Collections.Generic;
using System.Text;

namespace Class_n_Cons.Example1
{
    class Person
    {
        public string Name;

        public Person(string perName)
        {
            this.Name = perName;
        }

        public string GetName()
        {
            return this.Name;
        }
    }
}
