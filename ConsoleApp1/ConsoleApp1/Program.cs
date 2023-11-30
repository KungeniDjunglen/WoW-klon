using ConsoleApp1;
using System;

class Program
{
    static void Main()
    {
        List<Character> list = new List<Character>();
        list.Add(new Paladin("Gjörgen", 20, 50, 10));
        list.Add(new Barbarian("Juan", 50, 50, 10));
        list.Add(new Sorcerer("Bert", 10, 50, 10));


        Console.WriteLine("Skriv in dina stats (hp/damage) : ");
        int hp = int.Parse(Console.ReadLine());
        int Damage = int.Parse(Console.ReadLine());

        for (int i = 0; hp > 0 && list.Count > 0; )
        {
            list[0].Print();
            Console.WriteLine("Din HP: " + hp);
            Console.WriteLine("Vad vill du göra 1=attack, 2=heal ? ");
            int val = int.Parse(Console.ReadLine());
            switch (val)
            {
                case 1:
                    list[0].TakeDamage(Damage);
                    break;
                case 2:
                    hp += 20;
                    break;
            }
            if (list[0].HP <= 0)
            {
                list.Remove(list[0]);
                i++;
            }
            else
            {
                hp -= list[0].Damage;
            }
        }
        Console.WriteLine("Du vann eller förlora");



    }
}