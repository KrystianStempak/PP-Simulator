namespace Simulator;
using Simulator.Maps;

public class Program
{
    public static void Main(string[] args)
    {

        Point p = new(10, 25);
        Console.WriteLine(p.Next(Direction.Right));          // (11, 25)
        Console.WriteLine(p.NextDiagonal(Direction.Right));  // (11, 24)

        Lab5a();
        Lab5b();



        Console.ReadKey();


    }
    static void Lab5a()
    {
        try
        {
            Console.WriteLine("Creating rectangles with various points and coordinates:");

            // Test with coordinates
            Rectangle rect1 = new Rectangle(2, 3, 10, 8);
            Console.WriteLine(rect1);  // Expected: (2, 3):(10, 8)

            // Test with unordered coordinates
            Rectangle rect2 = new Rectangle(10, 8, 2, 3);
            Console.WriteLine(rect2);  // Expected: (2, 3):(10, 8)

            // Test with points
            Point p1 = new Point(4, 5);
            Point p2 = new Point(12, 15);
            Rectangle rect3 = new Rectangle(p1, p2);
            Console.WriteLine(rect3);  // Expected: (4, 5):(12, 15)

            // Test collinear points exception
            try
            {
                Rectangle invalidRect = new Rectangle(5, 5, 5, 10);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }

            // Test point containment
            Point testPointInside = new Point(6, 7);
            Point testPointOutside = new Point(1, 1);
            Console.WriteLine($"rect1.Contains{testPointInside}: {rect1.Contains(testPointInside)}"); // Expected: True
            Console.WriteLine($"rect1.Contains{testPointOutside}: {rect1.Contains(testPointOutside)}"); // Expected: False
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected exception: {ex.Message}");
        }
    }

    static void Lab5b()
    {
        try
        {
            // Test mapy o rozmiarze 10
            var map = new SmallSquareMap(10);
            Console.WriteLine($"Map size: {map.Size}");

            // Test punktów
            Point start = new Point(5, 5);
            Console.WriteLine($"Start point: {start}");

            // Test Next
            Console.WriteLine($"Next Up: {map.Next(start, Direction.Up)}");
            Console.WriteLine($"Next Right: {map.Next(start, Direction.Right)}");
            Console.WriteLine($"Next Down: {map.Next(start, Direction.Down)}");
            Console.WriteLine($"Next Left: {map.Next(start, Direction.Left)}");

            // Test NextDiagonal
            Console.WriteLine($"Next Diagonal Up: {map.NextDiagonal(start, Direction.Up)}");
            Console.WriteLine($"Next Diagonal Right: {map.NextDiagonal(start, Direction.Right)}");
            Console.WriteLine($"Next Diagonal Down: {map.NextDiagonal(start, Direction.Down)}");
            Console.WriteLine($"Next Diagonal Left: {map.NextDiagonal(start, Direction.Left)}");

            // Test wyjścia poza mapę
            Point outside = new Point(10, 10);
            Console.WriteLine($"Next Outside Point: {map.Next(outside, Direction.Up)}");

        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
