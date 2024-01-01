using System;

namespace tdc.avalonia.silvercity.Game.Base;

public struct Position(int x, int y)
{
    public bool Equals(Position other)
    {
        return X == other.X && Y == other.Y;
    }

    public override bool Equals(object? obj)
    {
        return obj is Position other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }

    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    public static Position operator +(Position a, Position b) => new(a.X + b.X, a.Y + b.Y);
    public static Position operator -(Position a, Position b) => new(a.X - b.X, a.Y - b.Y);
    public static Position operator *(Position a, int b) => new(a.X * b, a.Y * b);
    public static Position operator /(Position a, int b) => new(a.X / b, a.Y / b);

    public static bool operator ==(Position a, Position b) => a.X == b.X && a.Y == b.Y;
    public static bool operator !=(Position a, Position b) => !(a == b);
}