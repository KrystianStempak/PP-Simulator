using System;

namespace Simulator;

public readonly struct Point
{
    public readonly int X, Y;

    public Point(int x, int y) => (X, Y) = (x, y);

    public override string ToString() => $"({X}, {Y})";

    // Zwraca nowy punkt przesunięty o jedno pole w podanym kierunku
    public Point Next(Direction direction) =>
        direction switch
        {
            Direction.Up => new Point(X, Y + 1),
            Direction.Down => new Point(X, Y - 1),
            Direction.Left => new Point(X - 1, Y),
            Direction.Right => new Point(X + 1, Y),
            _ => this
        };

    // Zwraca nowy punkt przesunięty o jedno pole po skosie 45° zgodnie z ruchem wskazówek zegara
    public Point NextDiagonal(Direction direction) =>
        direction switch
        {
            Direction.Up => new Point(X + 1, Y + 1),
            Direction.Right => new Point(X + 1, Y - 1),
            Direction.Down => new Point(X - 1, Y - 1),
            Direction.Left => new Point(X - 1, Y + 1),
            _ => this
        };
}
