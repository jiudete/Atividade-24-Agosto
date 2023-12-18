using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex3
{
    internal class program
    { 
     

        static void Main(string[] args)
        {
            quadrado d = new quadrado(6);
         

            Console.WriteLine("A area do quadrado é {0}", d.CalculArea());
            Console.ReadKey();
        }
    }
}
