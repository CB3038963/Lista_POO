using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex4
{
    internal class Calculando
    {
        private int b, h, a;
        //construtore
        public Calculando() { this.b = 0; this.h = 0; }
        public Calculando(int b, int h) { this.b = b; this.h = h; }

        //set
        public void SetBase(int b) { this.b = b; }
        public void SetAltura(int h) { this.h = h; }
        //get
        public int GetBase() { return this.b; }
        public int GetAltura() { return this.h; }
        public int GetArea() { return this.a; }
        //resultado
        public void Calc() { this.a = (this.b * this.h) / 2; }
    }
}
