
using System;

class Calendar
{
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public void PrintWeekdays()
    {
        Console.WriteLine("Weekdays:");
        foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
        {
            if (day >= DaysOfWeek.Monday && day <= DaysOfWeek.Friday)
            {
                Console.WriteLine(day);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Calendar myCalendar = new Calendar();
        myCalendar.PrintWeekdays();
    }
}