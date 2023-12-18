using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lista_POOex3
{
    internal class quadrado
    #region atributos 
    {
        private double d;
        #endregion
        #region construtor 
        public quadrado(double d)
        {
            this.d = d;
        }
        #endregion
        #region metodoarea
        public double CalculArea()
        {
            double area = Math.Pow(this.d, 2) / 2;
            return area;
        }
        #endregion
    }
}

