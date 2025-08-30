using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maior maior = new Maior(10, 100);
            maior.Verificar();
            if (maior.GetMaior() > 0) { Console.WriteLine(maior.GetMaior()); }
            else { Console.WriteLine("Os números são identicos"); }
        }
    }
}
