using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIEGESZITES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key;
            Console.WriteLine("Nyomj meg egy billentyűt!");
            do
            {
                key = Console.ReadKey(true).Key;
                Console.WriteLine($"\nMegnyomtad a {key} billentyűt!");
            } while (key != ConsoleKey.Enter);
                Console.WriteLine("\nVége!");
                Console.ReadKey();
        }
    }
}
