namespace Simulator;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Starting Simulator!\n");
        Lab4();
        Console.ReadKey();
    }

    static void Lab4()
    {
        Console.WriteLine("HUNT TEST\n");
        var o = new Orc("Gorbag", level: 5, rage: 7);
        o.SayHi();
        for (int i = 0; i < 10; i++)
        {
            o.Hunt();
            o.SayHi();
        }

        Console.WriteLine("\nSING TEST\n");
        var e = new Elf("Legolas", agility: 2);
        e.SayHi();
        for (int i = 0; i < 10; i++)
        {
            e.Sing();
            e.SayHi();
        }

        Console.WriteLine("\nPOWER TEST\n");
        Creature[] creatures = {
            o,
            e,
            new Orc("Morgash", 3, 8),
            new Elf("Elandor", 5, 3)
        };
        foreach (Creature creature in creatures)
        {
            Console.WriteLine($"{creature.Name,-15}: {creature.Power}");
        }
    }
}
