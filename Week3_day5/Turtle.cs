using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day5
{
    class Turtle
    {
        //Tis static variable belongs to class
        //Tis is shared among all instances.
        //Tis also means we can use the variable without
        //creating instances first.
        static int turtleCount;

        public Turtle()
        {
            turtleCount++;
        }

        //Tis static Method belongs to the class.
        //It's shared among all instances.
        //It means we can use the Method without creating
        //any instances first.
        public static void WarCry()
        {
            Console.WriteLine("We are an army of {0} turtles", turtleCount);
        }
    }
}
