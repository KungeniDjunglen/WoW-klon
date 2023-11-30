using ConsoleApp1;
using System;

class Program
{
    static void Main()
    {
        List<Character> list = new List<Character>();
        list.Add(new Paladin("Gjörgen", 20, 50));
        list.Add(new Barbarian("Juan", 50, 50));
        list.Add(new Sorcerer("Bert", 10, 50));

        foreach (Character character in list)
        {
            character.Print();
        }

    }
}