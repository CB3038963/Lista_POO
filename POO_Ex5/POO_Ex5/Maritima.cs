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
        private int maritima = 1852;
        private int milhas;
        private int km;
        //construtores
        public Maritima () { this.km = 0; }
        public Maritima (int km) {  this.km = km; }
        //set
        public void SetKilo(int km) {  this.km=km; }
        //Get
        public int GetKilo() { return this.km; }
        public int GetMilhas() { return this.milhas; }
        //resultado
        public void Converter() { this.milhas = this.km * this.maritima; }

    }
}
