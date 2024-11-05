using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator;

public class Elf : Creature
{
    private int _agility;
    private int _singCount = 0;

    public int Agility
    {
        get => _agility;
        private set => _agility = value < 0 ? 0 : (value > 10 ? 10 : value);
    }

    public Elf(string name = "Unknown", int level = 1, int agility = 1)
        : base(name, level)
    {
        Agility = agility;
    }

    public void Sing()
    {
        Console.WriteLine($"{Name} is singing.");
        _singCount++;
        if (_singCount % 3 == 0 && Agility < 10)
        {
            Agility++;
        }
    }

    public override void SayHi() =>
        Console.WriteLine($"Hi, I'm {Name}, my level is {Level}, my agility is {Agility}.");

    public override int Power => 8 * Level + 2 * Agility;
}
