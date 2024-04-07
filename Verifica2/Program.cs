using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cerchio cerchio1 = Cerchio.Parse(Console.ReadLine());
            Cerchio cerchio2 = Cerchio.Parse(Console.ReadLine());
            Console.WriteLine("La somma: {0}", cerchio1 + cerchio2);
            Console.ReadLine();

        }
    }
}
