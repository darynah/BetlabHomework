using System;

namespace Overload
{
    public class Print
    {
        public void Display(string a)
        {
            Console.WriteLine();
        }
        public void Display(int c)
        {
            Console.WriteLine(c);
        }
    }
}