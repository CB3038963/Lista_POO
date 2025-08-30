using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcular calcular = new Calcular(10,10);
            calcular.calcular();
            if (calcular.GetArea() < 100) { Console.WriteLine("Terreno Pequeno"); }
            else { Console.WriteLine("Terreno Grande"); }
           
        }
    }
}
