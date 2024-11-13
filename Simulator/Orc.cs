using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator;

public class Orc : Creature
{
    private int _rage;
    private int _huntCount;

    public int Rage
    {
        get => _rage;
        private set => _rage = Validator.Limiter(value, 0, 10);
    }

    public Orc(string name = "Unknown", int level = 1, int rage = 1) : base(name, level)
    {
        Rage = rage;
    }

    public override string Info => $"{Name} [{Level}][{Rage}]";

    public override int Power => Level * 7 + Rage * 3;

    public override string Greeting() => $"Hi, I'm {Name}, my level is {Level}, my rage is {Rage}.";

    public void Hunt()
    {
        _huntCount++;
        if (_huntCount % 2 == 0 && Rage < 10) Rage++;
    }
}
