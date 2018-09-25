using System;

namespace Calculator
{
    class Program
    {
        static double number1;
        static double number2;
        static double operation;
        static void Main(string[] args)
        {
            Console.Write("Введите число 1: ");
            double number1 = ReadFromKey(Console.ReadLine());
            Console.Write("Введите число 2: ");
            double number2 = ReadFromKey(Console.ReadLine());
            Console.Write("Введите операцию: ");
            string operation = Console.ReadLine();
            Print(SuperCalc(number1, number2, operation));
            Console.ReadLine();
        }
        public static double ReadFromKey(string input)
        {
            double number;
            while (!Double.TryParse(input, out number))
            {
                if (!Double.TryParse(input, out number))
                    Console.WriteLine("Incorrect number!");
                break;
            }
            return number;
        }

        public static double SuperCalc(double number1, double number2, string operation)
        {
            double result = 0;
            var flag = 0;
            if (operation == "+")
                result = number1 + number2;
            else if (operation == "-")
                result = number1 - number2;
            else
                Console.WriteLine("Вы ввели неправильную операцию");
            return result;
        }
        public static void Print(double result)
        {
           Console.WriteLine("Pезультат: {0}", result);
        }
    }
}
