using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string? Name { get; set; } //? is to do Name as possible null.
        public int Age { get; set; } //case null value, 0 is the output

        public void IntroduceYourSelf()
        {
            Console.WriteLine($"Hi! My name is {Name} and I'm {Age}"); // $ is to allow interpolation
        }

    }
}
