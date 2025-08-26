using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex2
{
    internal class Calcular
    {
        private int aresta, a;
        //Construtores
        public Calcular() { this.aresta = 0; }
        public Calcular(int aresta) {  this.aresta = aresta; }
        //Set
        public void SetAresta(int aresta) { this.aresta = aresta; }
        //Get
        public int GetAresta() { return aresta; }
        public int GetA() { return a; }
        //Resultado
        public void Calc() { this.a=this.aresta*this.aresta; }
    }
}
