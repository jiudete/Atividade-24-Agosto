using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex2 
{ 
    internal class program
    { 
        static void Main(string[] args)
        {
           quadrado q;
            q = new quadrado(5.5);



            Console.WriteLine(" A área do quadrado é {0}" ,q.areaquadrado() );
            Console.ReadKey();

        }



    }
        

}
