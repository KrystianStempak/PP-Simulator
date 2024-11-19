using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Simulator;

namespace TestSimulator;

public class PointTests
{
    [Fact]
    public void Constructor_ShouldSetCoordinates()
    {
        var point = new Point(5, 10);
        Assert.Equal(5, point.X);
        Assert.Equal(10, point.Y);
    }

    [Theory]
    [InlineData(0, 0, Direction.Right, 1, 0)]
    [InlineData(5, 5, Direction.Left, 4, 5)]
    public void Next_ShouldReturnCorrectPoint(int x, int y, Direction direction, int expectedX, int expectedY)
    {
        var point = new Point(x, y);
        var next = point.Next(direction);
        Assert.Equal(new Point(expectedX, expectedY), next);
    }

    [Theory]
    [InlineData(0, 0, Direction.Up, 1, 1)]
    [InlineData(10, 10, Direction.Left, 9, 11)]
    public void NextDiagonal_ShouldReturnCorrectPoint(int x, int y, Direction direction, int expectedX, int expectedY)
    {
        var point = new Point(x, y);
        var next = point.NextDiagonal(direction);
        Assert.Equal(new Point(expectedX, expectedY), next);
    }
}
