using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex10
{
    internal class Peso
    {
        private double p, a, r;
        //construtores
        public Peso()
        { this.p = 0; this.a = 0; }
        public Peso(double a, double p)
        { this.p = p; this.a = a; }
        //set
        public void SetAltura(double p){this.p=p; }
        public void SetPeso(double p){this.p=p; }
        //get
        public double GetAltura() { return this.p; }
        public double GetPeso() { return this.p; }      
        public double GetResultado () { return this.r; }    
        //calculando
        public void calculo()
        { this.r = this.p / (Math.Pow(this.a, 2)); }
    }
}
