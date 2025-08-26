using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex3
{
    internal class Calcular
    {
        private int d, a;
        //Construtores
        public Calcular() { this.d = 0; }
        public Calcular(int d) { this.d = d; }
        //Set
        public void SetD(int d) { this.d = d; }
        //Get
        public int GetD() { return this.d; }
        public int GetArea() { return this.a; }

        //Resultado
        public void Calc()
        { this.a = this.d * this.d / 2; }

    }
}
