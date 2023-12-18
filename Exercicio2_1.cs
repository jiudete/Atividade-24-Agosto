using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_POOex2

{
    internal class quadrado

    {
        #region Atributos
        private double l;
        #endregion
        #region construtor
        public quadrado(double l)
        {
            this.l = l;
        }
        #endregion
        #region metodo
        public double areaquadrado()
        {
            double l = Math.Pow(this.l, 2);
            return l; 
        
        }
        #endregion

    }
}