using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex8
{
    internal class Maior
    {
        private double v1, v2, maior;
        //construtores
        public Maior() { }
        public Maior(double v1, double v2) { this.v1 = v1; this.v2 = v2; }
        //set
        public void SetV1(double v1) { this.v1 = v1; }
        public void SetV2(double v2) { this.v1 = v2; }
        //get
        public double GetMaior() { return this.maior; }
        public double GetV1() { return this.v1; }
        public double GetV2() { return this.v2; }
        //verificação
        public void Verificar()
        {
            if (this.v1 > this.v2) { this.maior = this.v1; }
            else if (this.v2 > this.v1) { this.maior = this.v2;}
            else { Console.WriteLine("Os dois sao identicos"); }
            
            
        }
    }
}
