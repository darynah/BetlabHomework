using System;
using Microsoft.VisualBasic;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
        Print a = new Print();
        a.Display(3);
        a.Display("Hi");
        Console.ReadLine();
        }       
    }
}
