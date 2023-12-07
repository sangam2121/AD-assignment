
using System;

class Car
{
    private string brand;
    private int year;
    private float price;

    public Car(string brand, int year, float price)
    {
        this.brand = brand;
        this.year = year;
        this.price = price;
    }

 
    public void DisplayCarDetails()
    {
        Console.WriteLine($"Brand: {brand}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Price: {price:C}");
    }
}

class Exercise1
{
    static void Main()
    {

        Car myCar = new Car("Bently", 2023, 25000000.50f);

        myCar.DisplayCarDetails();
    }
}
