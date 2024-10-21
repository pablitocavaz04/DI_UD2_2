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
        Console.Write("Introduce tu estado civil (C, S, V, D): ");
        char estadoCivil = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (estadoCivil)
        {
            case 'C':
                Console.WriteLine("Tu estado civil es Casad@");
                break;
            case 'S':
                Console.WriteLine("Tu estado civil es Solter@");
                break;
            case 'V':
                Console.WriteLine("Tu estado civil es Viud@");
                break;
            case 'D':
                Console.WriteLine("Tu estado civil es Divorciad@");
                break;
            default:
                Console.WriteLine("Estado civil no reconocido");
                break;
        }
    }
}
}
