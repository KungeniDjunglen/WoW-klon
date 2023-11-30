using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Barbarian: Character
    {
        public int RageLevel;
        public Barbarian(string name, int hp, int ragelevel, int damage)
        {
            this.Name = name;
            this.HP = hp;
            this.RageLevel = ragelevel;
            this.Damage = damage;
        }
        public override void Print()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.HP);
            Console.WriteLine(this.RageLevel);
        }
        public override void TakeDamage(int damage)
        {
            this.HP -= damage;
            this.RageLevel += damage;
        }
    }
}
