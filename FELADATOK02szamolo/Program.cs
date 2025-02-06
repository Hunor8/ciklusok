using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELADATOK02szamolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beker1,beker2;
            string muvelet;

            Console.Write("Adja meg az első számot: ");
            beker1 = int.Parse(Console.ReadLine());
            Console.Write("Adja meg az első számot: ");
            beker2 = int.Parse(Console.ReadLine());
            Console.Write("Add meg a műveletet: ");
            muvelet = Console.ReadLine();

            if (muvelet == "+")
            {
                Console.WriteLine($"Összeadást adtál meg, eredmény: {beker1+beker2}");
            }
            else if (muvelet == "-")
            {
                Console.WriteLine($"Kivonást adtál meg, eredmény: {beker1 - beker2}");
            }
            else if (muvelet == "/")
            {
                Console.WriteLine($"Osztást adtál meg, eredmény: {beker1 / beker2}");
            }
            else if (muvelet == "*")
            {
                Console.WriteLine($"Szorzást adtál meg, eredmény: {beker1 * beker2}");
            }

        }
    }
}
