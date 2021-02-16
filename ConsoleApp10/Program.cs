using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static List<Auto> lista;

        static void Main(string[] args)
        {
            lista = new List<Auto>();

            lista.Add(new Auto("Austin", 1969));
            lista.Add(new Auto("Ford", 1938));
            lista.Add(new Auto("Honda", 2017));
            lista.Add(new Auto("Mazda", 1990));

            foreach (Auto a in lista) a.TulostaTiedot();

            Console.WriteLine();

            lista.Sort();

            foreach (Auto a in lista) a.TulostaTiedot();

            Console.ReadLine();
        }
    }
}
