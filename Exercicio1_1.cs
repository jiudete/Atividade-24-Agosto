using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_POOex1
{

    internal class retangulo
    {
        #region Atributos
        private int b, h;
        #endregion
        #region metodo
        public int areacalc()
        {
            int a = this.b * this.h;
            return a;
        }
        #endregion
        #region construtor 
        public retangulo(int b, int h)
        {
            this.b = b;
            this.h = h;
        }
        #endregion


    }
}