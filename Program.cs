using System;
using System.Collections.Generic;
using System.IO;

namespace Zene_lejatszo
{
    internal class Program
    {
        class Zene
        {
            public string Cim = "";
            public string Eloado = "";
            public string Mufaj = "";
            public double HosszPerc;

            public override string ToString()
            {
                return $"{Cim} - {Eloado} | {Mufaj} | {HosszPerc} perc";
            }
        }
        static void Beolvas(List<Zene> zenek)
        {
            string fajl = "C:\\ujmappa\\playlist.txt";

            if (!File.Exists(fajl))
            {
                Console.WriteLine("A fájl nem található: " + fajl);
                Console.WriteLine("Üres lista indul.");
                Console.ReadKey();
                return;
            }

        }
    }
}
