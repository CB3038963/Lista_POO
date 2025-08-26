using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex6
{
    internal class Dolar
    {
        private double dolar, conversao;
        //construtores
        public Dolar() { this.dolar = 0; }
        public Dolar(int dolar) { this.dolar = dolar; }
        //set
        public void SetReal(int dolar){ this.dolar = dolar; }
        //get
        public double GetConversao() {  return this.conversao; }
        public double GetDolar() {  return this.dolar; }
       
        //resultado
        public void Converte() { this.conversao = this.dolar/5; }
        
        
    }
}
