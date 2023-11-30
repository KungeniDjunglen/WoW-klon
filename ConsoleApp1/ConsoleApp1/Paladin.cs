using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Paladin: Character
    {
        public int HolyPower;
        public Paladin(string name, int hp, int holypower, int damage)
        {
            this.Name = name;
            this.HP = hp;
            this.HolyPower = holypower;
            this.Damage = damage;

        }
        public override void Print()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.HP);
            Console.WriteLine(this.HolyPower);
        }
        public override void TakeDamage(int damage)
        {
            this.HolyPower -= damage;
            this.HP -= damage/2;
        }
    }
}
