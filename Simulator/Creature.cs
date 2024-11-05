using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator;

public abstract class Creature
{
    private string _name = "Unknown";
    private int _level = 1;

    public string Name
    {
        get => _name;
        set
        {
            if (_name != "Unknown") return;

            value = value.Trim();
            if (value.Length > 0 && char.IsLower(value[0]))
                value = char.ToUpper(value[0]) + value.Substring(1);
            if (value.Length < 3) value = value.PadRight(3, '#');
            if (value.Length > 25) value = value.Substring(0, 25).TrimEnd();
            if (value.Length < 3) value = value.PadRight(3, '#');
            _name = value;
        }
    }

    public int Level
    {
        get => _level;
        set
        {
            if (_level != 1) return;
            _level = value < 1 ? 1 : (value > 10 ? 10 : value);
        }
    }

    public Creature(string name = "Unknown", int level = 1)
    {
        Name = name;
        Level = level;
    }

    public virtual void SayHi()
    {
        Console.WriteLine($"Hi, I'm {Name}, and my level is {Level}.");
    }

    public abstract int Power { get; }
}
