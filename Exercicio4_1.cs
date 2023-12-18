using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex4
{
    internal class AreaTriangular
    {
        #region Atributos
        private double b, h;
        #endregion
        #region construtor

        public AreaTriangular(double b, double h)
        {
            this.b = b;
            this.h = h;
        }
        #endregion
        #region metodo 
        public double Area()
        {
            double area = b * h / 2;
            return area;

        }
        #endregion


    }
}

