using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcular calcular = new Calcular(10);
            calcular.Calc();
            Console.WriteLine(calcular.GetArea());
        }
    }
}
