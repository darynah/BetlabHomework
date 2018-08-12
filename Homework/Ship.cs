using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Ship
    {
        public int capacity = 10000;
        public string engine = "nengine";

        public Ship(int c, string t)
        {
            capacity = c*2;
            engine = t;

        }
        public Ship(int c)
        {
            capacity = c*2;

        }
        public Ship(string t)
        {
            engine = t;

        }
        public void PrintResults()
        {
            Console.WriteLine("capacity: "+ capacity + " engine: "+ engine);

        }



    }
}
