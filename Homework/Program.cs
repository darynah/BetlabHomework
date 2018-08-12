using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ship lodka = new Ship(5,"human_engine");
            lodka.PrintResults();

            Ship kater = new Ship(8, "mechanic");
            kater.PrintResults();

            Ship plot = new Ship(2);
            plot.PrintResults();

            Ship nopeople = new Ship("mechanic");
            nopeople.PrintResults();*/

            int s = 5;
            Counter count1 = new Counter();
            count1.Increase(s);
            Console.WriteLine("Value type ");
            count1.Print(s);
            Speed speed1 = new Speed();
            count1.Increase(speed1);
            Console.WriteLine("Reference type ");
            count1.Print(speed1.kmh);
            Console.ReadLine();
        }
    }
}