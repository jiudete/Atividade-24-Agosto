using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_POOex1
{
    internal class program
    {

        static void Main(string[]args)
        {

            retangulo c;
            c = new retangulo(4, 2);
            Console.WriteLine("A área do retângulo é {0} unidades aritmeticas", c.areacalc());
            Console.ReadKey();

        }

    }
}
