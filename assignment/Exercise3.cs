using System;

class Rectangle
{
    private float length;
    private float width;

    public Rectangle(float length, float width)
    {
        this.length = length;
        this.width = width;
    }

    public float CalculateArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main()
    {
        Rectangle myRectangle = new Rectangle(6.7f, 7.8f);
        float area = myRectangle.CalculateArea();
        Console.WriteLine($"The area of the rectangle is: {area}");
    }
}
