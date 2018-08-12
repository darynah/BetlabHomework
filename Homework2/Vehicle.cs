using System;

namespace Homework2
{
    public class Vehicle
    {
        public int Years;
        public int  WheelCount;
        public bool WasUsed;
        private static string Type;

        static Vehicle()
        {
            Console.WriteLine("I am a car");
        }

        public Vehicle(int wheel, bool used)
        {
            WheelCount = wheel;
            WasUsed = used;
        }

        public Vehicle(int wheel, int years)
        {
            WheelCount = wheel;
            Years = years;
            WasUsed = false;
        }

        public Vehicle(bool used, int years)
        {
            WasUsed = used;
            Years = years;
            WheelCount = 4;
        }

        public void PrintResults()
        {
            Console.WriteLine(Years + " "+" " + WheelCount +" "+ WasUsed);
        }

        public void SetType(string type)
        {
            Type = type;
        }

        public string GetType()
        {
            return Type;
        }
    }
}