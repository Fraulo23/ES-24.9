using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_24._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(2, 2);
            Vector v2= new Vector(3, 3);
            Vector v3 = Vector.parse("4;4");
            Console.WriteLine("La somma tra le componenti del vettore 1 e il vettore 2 sono: {0}:{1}", v1.Somma(v2).X, v1.Somma(v2).Y);
            Console.ReadLine();
        }
    }
}
