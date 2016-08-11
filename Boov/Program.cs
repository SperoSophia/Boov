/* Copyright © SperoSophia, 2016 */
using System;

namespace Boov
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser parser = new Parser();

            parser.Parse("1 + 2 * 3");

            foreach (var token in parser.Tokens)
                Console.WriteLine(token);

            Console.ReadLine();
        }
    }
}
