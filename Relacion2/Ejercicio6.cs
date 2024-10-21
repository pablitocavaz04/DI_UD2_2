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
            Console.Write("Introduce un número para calcular su factorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            long factorial = 1;

            for (int i = numero; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine($"El factorial de {numero} es: {factorial}");
        }
    }
}
