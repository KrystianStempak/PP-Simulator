using System;

namespace Simulator;

public class Rectangle
{
    public int X1 { get; }
    public int Y1 { get; }
    public int X2 { get; }
    public int Y2 { get; }

    // Konstruktor z czterema współrzędnymi
    public Rectangle(int x1, int y1, int x2, int y2)
    {
        // Zamiana współrzędnych jeśli są w złej kolejności
        if (x1 > x2) (x1, x2) = (x2, x1);
        if (y1 > y2) (y1, y2) = (y2, y1);

        // Sprawdzenie czy punkty są współliniowe
        if (x1 == x2 || y1 == y2)
            throw new ArgumentException("Invalid rectangle: Points are collinear.");

        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
    }

    // Konstruktor przyjmujący dwa punkty
    public Rectangle(Point p1, Point p2) : this(p1.X, p1.Y, p2.X, p2.Y) { }

    // Sprawdza, czy prostokąt zawiera podany punkt
    public bool Contains(Point point) =>
        point.X >= X1 && point.X <= X2 && point.Y >= Y1 && point.Y <= Y2;

    public override string ToString() => $"({X1}, {Y1}):({X2}, {Y2})";
}