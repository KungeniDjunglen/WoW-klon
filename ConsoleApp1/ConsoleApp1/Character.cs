using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Character
    {
        public string Name;
        public int HP;
        public int Damage;

        abstract public void Print();
        abstract public void TakeDamage(int damage);
    }
}
