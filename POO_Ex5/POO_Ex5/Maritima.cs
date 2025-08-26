using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex5
{
    internal class Maritima
    {
        private double milhaM = 1852;
        private double metro;
        private double milha;
        //construtores
        public Maritima () { this.milha = 0; }
        public Maritima (double milha) {  this.milha = milha; }
        //set
        public void SetMilha(double milha) {  this.milha=milha; }
        //Get
        public double GetMetro() { return this.metro; }
        public double GetMilha() {  return this.milha; }    
        
        //resultado
        public void Converter() { this.metro = this.milha * this.milhaM; }

    }
}
