using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Counter
    {
        public void Increase(int number) {
            number = number++;
        }
        public void Increase(Speed par) {
            par.kmh += 1;
        }
        public void Print(int value) {
            Console.WriteLine(value);
            }
        public void Print(Speed value)
        {
            Console.WriteLine(value.kmh);
            }
    }
}
