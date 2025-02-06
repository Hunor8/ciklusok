using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELADAT04pozitiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beker1, beker2;
            int osszead = 0;
            int db = 0;

            do
            {
                Console.Write("Adja meg a számot: ");
                beker1 = int.Parse(Console.ReadLine());
                if (beker1 < 0 && beker1 == 0) {
                    Console.WriteLine("Gratulálok");
                    db++;
                    
                }
                else if (beker1 > 0 && beker1 != 0)
                {
                    Console.WriteLine("Folytasd");
                    osszead += beker1;
                    db++;
                }
                Console.WriteLine($"Ennyi a számok összege: {osszead}");
                Console.WriteLine($"Ennyi a számot adtunk össze: {db}");
                
            }
            while (beker1 > 0 && beker1 != 0);


            /*for (int i = 0; i <= beker2; i++)
            {
                Console.WriteLine($"A szórzótáblája: {beker1} * {i} = {beker1 * i}");
            }*/
        }
    }
}
