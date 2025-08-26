using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex6
{
    internal class Dolar
    {
        private double real, conversao;
        //construtores
        public Dolar() { this.real = 0; }
        public Dolar(int real) { this.real = real; }
        //set
        public void SetReal(int real){ this.real = real; }
        //get
        public double GetConversao() {  return this.conversao; }
        public double GetReal() {  return this.real; }
       
        //resultado
        public void Converte() { this.conversao = this.real*5; }
        
        
    }
}
