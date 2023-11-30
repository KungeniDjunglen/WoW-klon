using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Sorcerer: Character
    {
        public int Mana;
        public Sorcerer(string name, int hp, int mana, int damage)
        {
            this.Name = name;
            this.HP = hp;
            this.Mana = mana;
            this.Damage = damage;
        }
        public override void Print()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.HP);
            Console.WriteLine(this.Mana);
        }
        public override void TakeDamage(int damage)
        {
            this.Mana -= damage;
            if(this.Mana < 0)
            {
                this.HP -= damage;
            }
        }
    }
}
