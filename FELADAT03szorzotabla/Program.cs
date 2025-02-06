using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELADAT03szorzotabla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beker1,beker2;
         
            Console.Write("Adja meg az első számot: ");
            beker1 = int.Parse(Console.ReadLine());
            Console.Write("Adja meg meddig menjen a szorzás: ");
            beker2 = int.Parse(Console.ReadLine());

            for (int i = 0; i <= beker2; i++)
            {
                Console.WriteLine($"A szórzótáblája: {beker1} * {i} = {beker1*i}");
            }
        }
    }
}
