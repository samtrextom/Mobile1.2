using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile1._2
{
    class Teahcer :Person
    {
        public int YearsOfService { get; set; }

        public override String ToString()
        {
            return "Teacher: " + Name + " Age: " + Age + " ID: " + ID + " Program: " + Program + " Years Of Service: " + YearsOfService;
        }
    }
}
