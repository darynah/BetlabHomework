using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace BetlabHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            Readlines("playlist.csv");
            Console.ReadLine();

        }

        private static void Readlines(string filename)
        {
           var input = int.Parse(Console.ReadLine());
           List<string> list = File.ReadAllLines("playlist.csv").ToList();
           Console.Write(list[input]);
           
           
        }
    }
}