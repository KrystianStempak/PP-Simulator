using System;

namespace Simulator.Maps;

/// <summary>
/// Represents a small torus map where movement wraps around edges.
/// </summary>
public class SmallTorusMap : Map
{
    private readonly int _size;

    /// <summary>
    /// Gets the size of the torus map.
    /// </summary>
    public int Size => _size;

    /// <summary>
    /// Initializes a new instance of the SmallTorusMap class.
    /// </summary>
    /// <param name="size">Size of the torus map.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown if size is not in the range [5, 20].
    /// </exception>
    public SmallTorusMap(int size)
    {
        if (size < 5 || size > 20)
        {
            throw new ArgumentOutOfRangeException(nameof(size), "Size must be between 5 and 20.");
        }

        _size = size;
    }

    /// <summary>
    /// Checks if the given point exists on the map.
    /// </summary>
    /// <param name="p">Point to check.</param>
    /// <returns>Always true for a torus map.</returns>
    public override bool Exist(Point p)
    {
        return p.X >= 0 && p.X < _size && p.Y >= 0 && p.Y < _size;
    }

    /// <summary>
    /// Gets the next point in the given direction, wrapping around edges.
    /// </summary>
    /// <param name="p">Starting point.</param>
    /// <param name="d">Direction to move.</param>
    /// <returns>Next point.</returns>
    public override Point Next(Point p, Direction d)
    {
        Point next = p.Next(d);

        int wrappedX = (next.X + _size) % _size;
        int wrappedY = (next.Y + _size) % _size;

        return new Point(wrappedX, wrappedY);
    }

    /// <summary>
    /// Gets the next diagonal point, wrapping around edges.
    /// </summary>
    /// <param name="p">Starting point.</param>
    /// <param name="d">Direction to move diagonally.</param>
    /// <returns>Next diagonal point.</returns>
    public override Point NextDiagonal(Point p, Direction d)
    {
        Point next = p.NextDiagonal(d);

        int wrappedX = (next.X + _size) % _size;
        int wrappedY = (next.Y + _size) % _size;

        return new Point(wrappedX, wrappedY);
    }
}
