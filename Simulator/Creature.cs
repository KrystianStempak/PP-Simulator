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
            _name = Validator.Shortener(value.Trim(), 3, 25, '#');
            if (char.IsLower(_name[0]))
                _name = char.ToUpper(_name[0]) + _name.Substring(1);
        }
    }

    public int Level
    {
        get => _level;
        set => _level = Validator.Limiter(value, 1, 10);
    }

    public Creature(string name = "Unknown", int level = 1)
    {
        Name = name;
        Level = level;
    }

    public abstract string Info { get; }

    public abstract int Power { get; }

    public virtual void SayHi() => Console.WriteLine($"Hi, I'm {Name}, my level is {Level}.");

    public void Upgrade()
    {
        if (Level < 10) Level++;
    }

    public override string ToString() => $"{GetType().Name.ToUpper()}: {Info}";
}
