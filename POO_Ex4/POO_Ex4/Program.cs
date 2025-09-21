using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculando triangulo = new Calculando(50, 10);
            triangulo.Calc();
            Console.WriteLine(triangulo.GetArea());
        }
    }
}
