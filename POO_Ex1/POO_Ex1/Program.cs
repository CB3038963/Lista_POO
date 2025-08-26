using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcular calcular = new Calcular(5,10);
            calcular.multiplicacao();
            Console.WriteLine(calcular.GetArea());
        }
    }
}
