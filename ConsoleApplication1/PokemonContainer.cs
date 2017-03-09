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
            //name hp ata def typ
            Console.WriteLine("Podaj imie: ");
            string i = Console.ReadLine();
            Console.WriteLine("Podaj hp: ");
            int hp = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj atak: ");
            int at = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj def: ");
            int def = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj typ: ");
            string typ = Console.ReadLine();

            //musze stworzyc instancje obiektu pokemon i wskazac wejscie
            Pokemon p = new Pokemon(i,hp,at,def,typ);

            pokeList.Add(p);
            Console.Clear();


        }


    }
}
