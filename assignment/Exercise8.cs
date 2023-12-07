
using System;

struct Point2D
{
    public float X { get; set; }
    public float Y { get; set; }
}

class DistanceCalculator
{
    public static float CalculateDistance(Point2D point1, Point2D point2)
    {
        float deltaX = point2.X - point1.X;
        float deltaY = point2.Y - point1.Y;
        return (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
}

class Program
{
    static void Main()
    {
        Point2D pointA = new Point2D { X = 2.0f, Y = 3.0f };
        Point2D pointB = new Point2D { X = 5.0f, Y = 7.0f };
        float distance = DistanceCalculator.CalculateDistance(pointA, pointB);
        Console.WriteLine($"Distance between Point A and Point B: {distance}");
    }
}
