using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine
{
    class korduslaused
    {
        public static void Main(string[] args)
        {
            string[] nimed= new string[7] {"Artem","Artjom","Alexy","Jaan","Nikita","Aljona","Nikolaj"};
            nimed[2] = "Anna";
            int nr = 0;
            while (nr<7)
            {
                nr++;
                Console.WriteLine($"Tere, {nr} õpilane. Sinu nimi on {nimed[nr - 1]}");
            }
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine("Tere, {0} õpilane", nimed[i]);
            }
            Console.WriteLine("-------------------------------------");
            foreach (var nimi in nimed)
            {
                Console.WriteLine("Tere, {0} õpilane", nimi);
            }
            Console.WriteLine("-------------------------------------");
            nr = 0;
            do
            {
                Console.WriteLine("Tere, {0} õpilane", nimed[nr]);
                nr++;
            } while (nr!=nimed.Length);

            Console.ReadLine();
        }
    }
}
