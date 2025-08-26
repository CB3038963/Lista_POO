using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex1
{
    internal class Calcular
    {
        private int b, h, a;
        //Construtores
        public Calcular() { this.b = 0; this.h = 0; }
        public Calcular(int b, int h) { this.b = b; this.h = h; }
        //Set
        public void SetBase(int b) { this.b = b; }
        public void SetAltura(int h) { this.h = h; }
        //Get
        public int GetBase() { return this.b; }
        public int GetAltura() { return this.h; }
        public int GetArea() { return this.a; }
        //Calculo final
        public void multiplicacao()
        {
            this.a = this.b * this.h;
        }
    }
}
