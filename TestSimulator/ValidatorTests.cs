using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Simulator;

namespace TestSimulator;

public class ValidatorTests
{
    [Theory]
    [InlineData(5, 0, 10, 5)]   // Within range
    [InlineData(-1, 0, 10, 0)]  // Below range
    [InlineData(15, 0, 10, 10)] // Above range
    public void Limiter_ShouldReturnClampedValue(int value, int min, int max, int expected)
    {
        Assert.Equal(expected, Validator.Limiter(value, min, max));
    }

    [Theory]
    [InlineData("example", 3, 5, '.', "exa...")]
    [InlineData("test", 3, 5, '-', "test")]
    [InlineData("short", 3, 4, '*', "sho*")]
    public void Shortener_ShouldReturnCorrectString(string value, int min, int max, char placeholder, string expected)
    {
        Assert.Equal(expected, Validator.Shortener(value, min, max, placeholder));
    }
}
