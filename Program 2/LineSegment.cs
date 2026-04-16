internal class LineSegment
{
    private double x;
    private double y;

    public LineSegment(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public LineSegment(LineSegment other)
    {
        this.x = other.x;
        this.y = other.y;
    }

    public override string ToString()
    {
        return $"[{x}, {y}]";
    }

    public static double operator !(LineSegment segment)
    {
        return Math.Abs(segment.y - segment.x);
    }

    public static LineSegment operator ++(LineSegment segment)
    {
        return new LineSegment(segment.x - 1, segment.y + 1);
    }

    public static implicit operator int(LineSegment segment)
    {
        return (int)segment.x;
    }

    public static explicit operator double(LineSegment segment)
    {
        return segment.y;
    }

    public static LineSegment operator -(LineSegment segment, int number)
    {
        return new LineSegment(segment.x - number, segment.y);
    }

    public static LineSegment operator -(int number, LineSegment segment)
    {
        return new LineSegment(segment.x, segment.y - number);
    }

    public static bool operator <(LineSegment a, LineSegment b)
    {
        double a1 = Math.Min(a.x, a.y);
        double a2 = Math.Max(a.x, a.y);
        double b1 = Math.Min(b.x, b.y);
        double b2 = Math.Max(b.x, b.y);

        return !(a2 < b1 || b2 < a1);
    }

    public static bool operator >(LineSegment a, LineSegment b)
    {
        return false;
    }
}