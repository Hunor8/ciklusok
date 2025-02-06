using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELADAT01szamkit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam,beker,db;
            db = 0;
            
            do
            {
                Console.Write("Gondoltam  új számra: ");
                Random vszam = new Random();
                szam = vszam.Next(0, 100 + 1);
                beker = int.Parse(Console.ReadLine());

                if (beker == szam)
                {
                    db++;
                    Console.WriteLine("Ugyan arra gondoltunk hey");
                    Console.WriteLine($"A generált szám: {szam}");
                    Console.WriteLine($"Ennyi próbából: {db}");
                }

                else if (beker != szam)
                {
                    db++;
                    Console.WriteLine("Sajnos nem talált");
                    Console.WriteLine($"A generált szám: {szam}");
                    Console.WriteLine($"Ennyi próbából: {db}");
                }
            } while (beker != szam);







            Console.ReadKey();
        }
    }
}
