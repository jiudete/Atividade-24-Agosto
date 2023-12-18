using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex4
{
   internal class program
   {
        static void Main(string[] args)
        {
         AreaTriangular r = new AreaTriangular(3,8);
          

            Console.WriteLine(" A área triangular é {0}",r.Area());
            Console.ReadKey();
        }
   }
}
