using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            PokemonContainer p = new PokemonContainer();
            p.ShowC();
            Console.WriteLine("Podaj wartosc: ");
            int value = int.Parse(Console.ReadLine());
            p.DeleteP(value);
            Console.Clear();
            p.ShowC();
            Console.ReadLine();
            p.AddP();
            p.ShowC();
            Console.ReadLine();

        }
    }
}
