using System;

class Shape
{

    public virtual float CalculateArea()
    {
        return 0;
    }
}

class Circle : Shape
{
    private float radius;

    public Circle(float radius)
    {
        this.radius = radius;
    }

    public override float CalculateArea()
    {
        return (float)(Math.PI * Math.Pow(radius, 4));
    }
}

class Exercise5
{
    static void Main()
    {
        Circle myCircle = new Circle(8);

        float area = myCircle.CalculateArea();
        Console.WriteLine($"The area of the circle with radius 5 is: {area}");
    }
}
