using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maior maior = new Maior(50,10);
            maior.Verificar();
            Console.WriteLine(maior.GetMaior());
        }
    }
}
