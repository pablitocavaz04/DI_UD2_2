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
            Console.Write("Introduce el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El número mayor es: {(num1 > num2 ? num1 : num2)}");
        }
    }
}
