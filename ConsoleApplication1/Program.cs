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

            while (true)
            {



                try
                {
                    p.AddP();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());
                }

                p.ShowC();

                Console.WriteLine("Podaj numer pokemona: ");

                try
                {
                    int index = int.Parse(Console.ReadLine());
                    p.DeleteP(index);
                    p.ShowC();
                    Console.ReadLine();
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.ToString());
                }
              

               
                

                
            }


        }
    }
}
