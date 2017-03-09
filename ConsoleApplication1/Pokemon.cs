using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pokemon
    {
        public string name;
        public int? hp;
        public int attack;
        public int defense;
        public string type;

        public Pokemon(string name,int hp, int attack, int defense, string type)
        {
            this.name = name;
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
            this.type = type;


        }

       

        public string ShowP()
        {

            return string.Format("Name: " + name + " " + hp + " " + attack + defense + type);

        }




    }
}
