using System;
using System.Collections.Generic;
using System.Linq;

namespace ConditionalStatementsСycles
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "mghhhopheylalaley";
            char[] array = input.ToCharArray();
            var dictionary = new Dictionary<char, int>();
            foreach (var ch in array)
            {
                if (!dictionary.ContainsKey(ch))
                    dictionary[ch] = 1;
                else
                {
                    dictionary[ch] = dictionary[ch] + 1;
                }
            }
            char x = 'o';
            foreach (var pair in dictionary)
            {
                if (pair.Value == 1)
                {
                    x = pair.Key;
                    int indexofchar = input.IndexOf(x);
                    Console.WriteLine(indexofchar + " " + x);
                }
                
            }
            Console.ReadLine();
        }

        /*static void Main(string[] args)
        {
            string input = "mghhhopheylalaley";

            var singleChar = input.GroupBy(z => z).First(y => y.Count() == 1).Key;
            Console.WriteLine(input.IndexOf(singleChar));
            Console.ReadLine();
        }*/

    }
}