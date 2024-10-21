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
            Console.Write("Introduce el tamaño del array: ");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                Console.Write($"Introduce el valor para el índice {i}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Números pares:");
            foreach (int num in numeros)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }

            Console.WriteLine("Números impares:");
            foreach (int num in numeros)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
