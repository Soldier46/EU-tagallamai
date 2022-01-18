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
    }
    }
}
