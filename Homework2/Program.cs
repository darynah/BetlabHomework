using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle newMotorcicle = new Vehicle(2,false);
            Vehicle oldCar = new Vehicle(4, 1966);
            Vehicle newCar = new Vehicle(false,2018); // implement
            Vehicle someCar; // declare 

            newMotorcicle.SetType("Mercedes");
            Console.WriteLine(oldCar.GetType());
            Console.WriteLine(newCar.GetType());
            
            Console.ReadLine();
            ;
        }
    }
}