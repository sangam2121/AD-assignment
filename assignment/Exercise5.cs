
 using System;

class Student
{
    private string name;
    private int age;
    private string major;

    public Student(string name, int age, string major)
    {
        this.name = name;
        this.age = age;
        this.major = major;
    }

    public void Introduce()
    {
        Console.WriteLine($"Yo, I'm {name} and I'm {age} years old majoring in {major}.");
    }
}

internal class Program
{
    static void Main()
    {
        Student johnDoe = new Student("Monev", 22, "BIT");
        johnDoe.Introduce();
    }
}
