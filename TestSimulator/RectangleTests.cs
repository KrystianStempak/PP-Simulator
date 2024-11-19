using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Simulator;

namespace TestSimulator;

public class RectangleTests
{
    [Fact]
    public void Constructor_ShouldSetProperties()
    {
        var rect = new Rectangle(0, 0, 10, 10);
        Assert.Equal(0, rect.X1);
        Assert.Equal(0, rect.Y1);
        Assert.Equal(10, rect.X2);
        Assert.Equal(10, rect.Y2);
    }

    [Theory]
    [InlineData(5, 5, 0, 0, 10, 10, true)]
    [InlineData(15, 5, 0, 0, 10, 10, false)]
    public void Contains_ShouldReturnCorrectValue(int x, int y, int x1, int y1, int x2, int y2, bool expected)
    {
        var rect = new Rectangle(x1, y1, x2, y2);
        Assert.Equal(expected, rect.Contains(new Point(x, y)));
    }
}
