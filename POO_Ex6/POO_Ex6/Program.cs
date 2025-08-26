using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar(5);  
            dolar.Converte();
            Console.WriteLine(dolar.GetConversao());
        }
    }
}
