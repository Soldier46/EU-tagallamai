using System.IO;
using System.Threading;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Dynamic;
using System;


namespace EU_tagallamai
{
    class Program
    {
        static void Main(string[] args)
        {
            List<eu> eupa = new List<eu>();
            foreach (var i in File.ReadAllLines("EUcsatlakozas.txt"))
            {
                eupa.Add(new eu(i));
            }
            Console.WriteLine($"3.feladat: eu tagállamainak a száma { eupa.Count}db");


            
            int csatlakozas = 0;
            foreach (var i in eupa)
            {
                if (i.dátum.Date.Year == 2007)
                {
                    csatlakozas++;
                }
            }
            Console.WriteLine($"4.feladat: 2007-ben {csatlakozas} csatlakozott országok ");

            foreach (var i in eupa)
            {
                if (i.orszag == "Magyarország")
                {
                    Console.WriteLine($"5.feladat : magyarorszag csatlakozasanak datuma {i.dátum}");
                }
            }
            foreach (var i in eupa)
            {
                if (i.dátum.Date.Month == 05)
                {
                    Console.WriteLine($"6.feladat : Májusban történt csatlakozás");
                    break;
                }
               
            }
            foreach (var i in eupa)
            {
                if (i.dátum.Date.Year == 2013)
                {
                    Console.WriteLine($"7.feladat : utoljára csatlakozott ország {i.orszag}");

                }
            }

            Dictionary<int, int> faszsetudja = new Dictionary<int, int>();

            foreach (var i in eupa)
            {
                if (faszsetudja.ContainsKey(i.dátum.Year))
                {
                    faszsetudja[i.dátum.Year]++;

                }
                else
                {
                    faszsetudja.Add(i.dátum.Year,1);

                }
            }
            Console.WriteLine("8.feladat : statisztika");

            foreach (var i in faszsetudja)
            {
                Console.WriteLine($"\t{i.Key} - {i.Value} ország");
            }

        }
    }
}
