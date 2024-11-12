using System;
using Simulator.Maps;

namespace Simulator.Maps
{
    /// <summary>
    /// Represents a small square map with size between 5 and 20 points.
    /// </summary>
    public class SmallSquareMap : Map
    {
        private int _size;

        /// <summary>
        /// Gets the size of the map (side length).
        /// </summary>
        public int Size => _size;

        /// <summary>
        /// Constructor to initialize a small square map.
        /// Throws ArgumentOutOfRangeException if the size is not between 5 and 20.
        /// </summary>
        /// <param name="size">Size of the square map.</param>
        public SmallSquareMap(int size)
        {
            if (size < 5 || size > 20)
            {
                throw new ArgumentOutOfRangeException(nameof(size), "Size must be between 5 and 20.");
            }

            _size = size;
        }

        /// <summary>
        /// Checks if the given point is within the bounds of the map.
        /// </summary>
        /// <param name="p">Point to check.</param>
        /// <returns>True if the point is within bounds of the map, otherwise false.</returns>
        public override bool Exist(Point p)
        {
            return p.X >= 0 && p.X < _size && p.Y >= 0 && p.Y < _size;
        }

        /// <summary>
        /// Returns the next position to the point in a given direction.
        /// If the move would take the point outside the map, it returns the current point.
        /// </summary>
        /// <param name="p">Starting point.</param>
        /// <param name="d">Direction.</param>
        /// <returns>Next point after moving in the specified direction, or the original point if out of bounds.</returns>
        public override Point Next(Point p, Direction d)
        {
            Point next = p.Next(d);

            if (!Exist(next))
            {
                return p; // Return the original point if the move goes out of bounds.
            }

            return next;
        }

        /// <summary>
        /// Returns the next diagonal position to the point in a given direction rotated 45 degrees clockwise.
        /// If the move would take the point outside the map, it returns the current point.
        /// </summary>
        /// <param name="p">Starting point.</param>
        /// <param name="d">Direction.</param>
        /// <returns>Next diagonal point, or the original point if out of bounds.</returns>
        public override Point NextDiagonal(Point p, Direction d)
        {
            Point next = p.NextDiagonal(d);

            if (!Exist(next))
            {
                return p; // Return the original point if the move goes out of bounds.
            }

            return next;
        }
    }
}
