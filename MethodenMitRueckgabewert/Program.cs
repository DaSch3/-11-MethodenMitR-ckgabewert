using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodenMitRueckgabewert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Subtraktion(10, 5));
            Console.ReadKey();
        }

        static int Subtraktion(int zahl1, int zahl2)
        {
            int ergebnis = zahl1 - zahl2;
            return ergebnis;
        }
    }
}
