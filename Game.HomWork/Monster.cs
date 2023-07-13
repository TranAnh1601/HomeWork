using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.HomWork
{
    internal class Monster
    {
        public string Name { get; set; }
        public int Hp { get; set; }

        public Monster(string name, int hp)
        {
            Name = name; Hp = hp;
        }
    }
}
