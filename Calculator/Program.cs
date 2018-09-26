using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число 1: ");
            double number1 = ReadFromKey();
            Console.Write("Введите число 2: ");
            double number2 = ReadFromKey();
            Console.Write("Введите операцию: ");
            string operation = Console.ReadLine();
            SuperCalc(number1, number2, operation);
            Console.ReadLine();
        }
        public static double ReadFromKey()
        {
            double number;
            while (!Double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Вы ввели неправильное число: ");
                Console.ReadLine();// для того чтобы консоль не закрывалась
            }
            return number;
        }
        public static void SuperCalc(double number1, double number2, string operation)
        {
            if (operation == "+")

                Console.WriteLine("Pезультат: {0}", number1 + number2);
            else if (operation == "-")
                Console.WriteLine("Pезультат: {0}", number1 - number2);
            else
                Console.WriteLine("Вы ввели неправильную операцию");
        }
    }
}

