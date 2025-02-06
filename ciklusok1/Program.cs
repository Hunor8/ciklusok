using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciklusok1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam1,szam2,szamvel;

            Random vszam = new Random();

            szam1 = int.Parse(Console.ReadLine());
            szam2 = int.Parse(Console.ReadLine());


            szamvel = vszam.Next(szam1,szam2+1);
            
            Console.WriteLine(szamvel);
        }
    }
}
