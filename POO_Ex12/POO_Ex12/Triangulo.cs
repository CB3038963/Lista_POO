using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex12
{
    internal class Triangulo
    {
        private double a, b, c;
        //construtores
        public Triangulo()
        { this.a = 0; this.b = 0; this.c = 0; }
        public Triangulo(double a, double b, double c)
        { this.a = a; this.b = b; this.c = c; }
        //set
        public void SetA(double a) { this.a = a; }
        public void SetB(double b) { this.b = b; }
        public void SetC(double c) { this.c = c; }
        //get
        public double GetA() { return this.a; }
        public double GetB() { return this.b; }
        public double GetC() { return this.c; }
        //resolução
        public void calculo()
        {
            if (Math.Pow(this.a, 2) == Math.Pow(this.b, 2) + Math.Pow(this.c, 2) || 
                Math.Pow(this.b, 2) == Math.Pow(this.a, 2) + Math.Pow(this.c, 2) ||
                Math.Pow(this.c, 2) == Math.Pow(this.a, 2) + Math.Pow(this.b, 2))
            { Console.WriteLine("Forma um Triangulo Retangulo"); }
            else { Console.WriteLine("Não forma um Triangulo Retangulo"); }
        }
    }
}
