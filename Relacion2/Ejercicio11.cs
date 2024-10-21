using System;
using System.Collections;
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
            Stack pila = new Stack();
            Console.Write("¿Cuántos valores deseas introducir en la pila? ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Introduce el valor {i + 1}: ");
                pila.Push(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Valores en la pila:");
            foreach (int valor in pila)
            {
                Console.WriteLine(valor);
            }

            // Sacar dos elementos
            pila.Pop();
            pila.Pop();

            Console.WriteLine("Valores en la pila tras sacar dos elementos:");
            foreach (int valor in pila)
            {
                Console.WriteLine(valor);
            }
        }
    }
}
