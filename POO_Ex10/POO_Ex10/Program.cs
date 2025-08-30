using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Peso peso = new Peso(1.85,90);
            peso.calculo();
            if (peso.GetResultado() < 20) { Console.WriteLine("Abaixo do peso"); }
            else if (peso.GetResultado() > 20 &&  peso.GetResultado() < 25) { Console.WriteLine("Peso ideal"); }
            else { Console.WriteLine("Acima do peso"); }
        }
    }
}
