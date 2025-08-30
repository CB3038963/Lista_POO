using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex9
{
    internal class Calcular
    {
        private double b, h, a;
        //construtores
        public Calcular () { b = 0; h = 0; }
        public Calcular (double b, int h) { this.b = b; this.h = h; }
        //set
        public void SetBase(double b) { this.b = b; }
        public void SetAltura(double h) { this.h = h; }
        //get
        public double GetBase() { return this.b; }
        public double GetAltura () { return this.h; }   
        public double GetArea () { return this.a; }
        //calculando a area
        public void calcular ()

        { this.a = this.b * this.h; }

    }
}
