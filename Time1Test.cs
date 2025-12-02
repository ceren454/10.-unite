using System;

class Time1Test
{
    static void Main()
    {
        Time1 time = new Time1();

        Console.WriteLine($"Initial universal time: {time.ToUniversalString()}");
        Console.WriteLine($"Initial standard time: {time}");

        Console.WriteLine();

        time.SetTime(13, 27, 6);
        Console.WriteLine($"Universal time after change: {time.ToUniversalString()}");
        Console.WriteLine($"Standard time after change: {time}");

        Console.WriteLine();

        try
        {
            time.SetTime(99, 99, 99);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Exception caught: " + e.Message);
        }

        Console.WriteLine();

        Console.WriteLine("Time after invalid attempt:");
        Console.WriteLine($"Universal time: {time.ToUniversalString()}");
        Console.WriteLine($"Standard time: {time}");
    }
}
