using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam1, szam2;
            szam1 = int.Parse(Console.ReadLine());
            szam2 = int.Parse(Console.ReadLine());

            for (int i = szam1; i <= szam2; i++)
            {
                if (i % 2 == 0)  
                    Console.WriteLine(i);
            }
        }
    }
}
