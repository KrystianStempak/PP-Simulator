using Simulator;
using Simulator.Maps;

namespace TestSimulator;

public class SmallSquareMapTests
{
    [Fact]
    public void Constructor_ValidSize_ShouldSetSize()
    {
        var map = new SmallSquareMap(10);
        Assert.Equal(10, map.Size);
    }

    [Theory]
    [InlineData(4)]
    [InlineData(21)]
    public void Constructor_InvalidSize_ShouldThrowArgumentOutOfRangeException(int size)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new SmallSquareMap(size));
    }

    [Theory]
    [InlineData(0, 0, 5, true)]
    [InlineData(4, 4, 5, true)]
    [InlineData(5, 5, 5, false)]
    [InlineData(-1, -1, 5, false)]
    public void Exist_ShouldReturnCorrectValue(int x, int y, int size, bool expected)
    {
        var map = new SmallSquareMap(size);
        Assert.Equal(expected, map.Exist(new Point(x, y)));
    }

    [Theory]
    [InlineData(0, 0, Direction.Right, 1, 0)]
    [InlineData(4, 4, Direction.Down, 4, 4)] // Edge, no movement allowed
    public void Next_ShouldReturnCorrectPoint(int x, int y, Direction direction, int expectedX, int expectedY)
    {
        var map = new SmallSquareMap(5);
        var point = new Point(x, y);
        var next = map.Next(point, direction);
        Assert.Equal(new Point(expectedX, expectedY), next);
    }
}
