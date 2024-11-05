using System;

namespace Simulator;

public static class Validator
{
    public static int Limiter(int value, int min, int max) => Math.Max(min, Math.Min(value, max));

    public static string Shortener(string value, int min, int max, char placeholder)
    {
        value = value.Length > max ? value.Substring(0, max).TrimEnd() : value;
        if (value.Length < min) value = value.PadRight(min, placeholder);
        return char.IsLower(value[0]) ? char.ToUpper(value[0]) + value.Substring(1) : value;
    }
}
