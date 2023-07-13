using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.HomWork
{
    internal class SuperMan
    {
        public string Name { get; set; }
        //private int hp;

        //public int Hp
        //{
        //    get { return hp; }
        //    set { hp = 100; }
        //}

        public int Hp { get; set; }
                
        public SuperMan(string name , int hp =100)
        {
            Name = name; Hp = hp;
        }
        public void Attack(Monster monster)
        {
            Hp -= 1;
            monster.Hp -= 10;
           
            if (monster.Hp <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Monter Die!");
            }
            if (Hp == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SuperMan Die!");
            }
        }
    }
}
