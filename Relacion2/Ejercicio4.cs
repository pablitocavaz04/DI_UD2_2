using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacion2
{

    class Program
    {
        static void Main()
        {
            Console.Write("Introduce una cadena de texto: ");
            string texto = Console.ReadLine();

            Console.WriteLine($"Longitud: {texto.Length}");
            Console.WriteLine($"Contiene 'ejemplo': {texto.Contains("ejemplo")}");
            Console.WriteLine($"Reemplazo de 'a' por 'o': {texto.Replace('a', 'o')}");
            Console.WriteLine($"Todo en mayúsculas: {texto.ToUpper()}");
            Console.WriteLine($"Todo en minúsculas: {texto.ToLower()}");
            Console.WriteLine($"Eliminar carácter en posición 2: {texto.Remove(2, 1)}");
            Console.WriteLine($"Subcadena (pos 1 a 4): {texto.Substring(1, 3)}");
        }
    }
}
