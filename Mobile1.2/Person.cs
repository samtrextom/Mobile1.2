using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile1._2
{
    enum ProgramEnum
    {
        Blank,
        Computer_Science,
        Accounting,
        Marketing,
        Nursing

    }
    class Person
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
        public ProgramEnum Program { get; set; }
    }
}
