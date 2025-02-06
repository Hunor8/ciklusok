using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELADATOK05pénz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int bekerOssz,bekerKolts,aktual;
            

            Console.Write("Adja meg az összeget: ");
            bekerOssz = int.Parse(Console.ReadLine());
            
            do
            {
                Console.Write("Adja meg a költséget: ");
                bekerKolts = int.Parse(Console.ReadLine());
                bekerOssz = bekerOssz - bekerKolts;
                Console.WriteLine($"Aktuális egyenleg: {bekerOssz}");
            } while (bekerOssz != 0);

        }
    }
}
