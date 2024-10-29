namespace Simulator;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Starting Simulator!\n");

        Creature dragon = new Creature("Dragon", 10);
        dragon.SayHi();

        Creature unknownCreature = new Creature();
        unknownCreature.Name = "Unknown";
        unknownCreature.Level = 1;
        unknownCreature.SayHi();

        Animals dogs = new Animals { Description = "Dogs", Size = 5 };
        Console.WriteLine(dogs.Info); 
    }
}
