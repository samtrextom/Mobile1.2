using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile1._2
{
    class Student :Person
    {
        public int CreditsEarned { get; set; }

        public override String ToString()
        {
            return "Student: " + Name + " Age: " + Age + " ID: " + ID + " Program: " + Program + " Credits Earned: " + CreditsEarned;
        }
    }
}
