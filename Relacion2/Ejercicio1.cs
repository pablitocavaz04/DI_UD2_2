using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacion2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Introduce la cantidad de Kilowatios consumidos: ");
            double kilowatios = Convert.ToDouble(Console.ReadLine());
            double coste;

            if (kilowatios > 1800)
            {
                coste = kilowatios * 0.08;
            }
            else if (kilowatios >= 1000)
            {
                coste = kilowatios * 0.12;
            }
            else
            {
                coste = kilowatios * 0.14;
            }

            Console.WriteLine($"Total a pagar: {coste:C}");
        }
    }
}
