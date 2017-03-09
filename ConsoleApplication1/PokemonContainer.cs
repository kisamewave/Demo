using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PokemonContainer
    {
        List<Pokemon> pokeList = new List<Pokemon>();

        public PokemonContainer()
        {

            pokeList.Add(new Pokemon("Pikachu", 82, 52, 51, "Yellow"));
            pokeList.Add(new Pokemon("Alakazam", 90, 45, 32, "Purple"));

        }

        public void ShowC()
        {
            foreach (Pokemon item in pokeList)
            {
                Console.WriteLine(item.ShowP());
            }


        }

        public void DeleteP(int index)
        {

            pokeList.RemoveAt(index);

        }

        public void AddP()
        {

            pokeList.Add(new Pokemon(
                Console.ReadLine(), 
                int.Parse(Console.ReadLine()), 
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine()), 
                Console.ReadLine()));
            Console.Clear();


        }


    }
}
