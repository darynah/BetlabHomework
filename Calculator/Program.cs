using System;

namespace Calculator
{
    class Program
    {
        static double number1;
        static double number2;
        static string operation;
        static void Main(string[] args)
        {
            Console.Write("Введите число 1: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число 2: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите операцию: ");
            string operation = Console.ReadLine();
            Print(SuperCalc( number1,  number2,  operation));
            Console.ReadLine();
        }
        public static double SuperCalc(double number1, double number2, string operation)
        {
            double result = 0;
            if (operation == "+")
                result = number1 + number2;
            else if (operation == "-")
                result = number1 - number2;
            else Console.WriteLine("Вы ввели неправильную операцию");
            return result;
        }
        public static void Print(double result)
        {
            Console.WriteLine("Pезультат: {0}", result);
        }
    }
}
