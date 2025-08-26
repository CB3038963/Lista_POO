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
            Maior maior = new Maior(100,10);
            maior.Verificar();
            Console.WriteLine(maior.GetMaior());
        }
    }
}
