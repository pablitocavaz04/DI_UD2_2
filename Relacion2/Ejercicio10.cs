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
            int[] numeros = { 5, 2, 9, 1, 5, 6, 3, 8, 7, 4 };
            Array.Sort(numeros);

            Console.WriteLine("Array ordenado:");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
        }
    }
}
