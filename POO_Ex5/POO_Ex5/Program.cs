using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maritima maritima = new Maritima(2);
            maritima.Converter();
            Console.WriteLine(maritima.GetMetro());
        }
    }
}
