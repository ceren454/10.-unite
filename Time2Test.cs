using System;

public class Time2Test
{
    static void Main()
    {
        Time2 t1 = new();
        Time2 t2 = new(2);
        Time2 t3 = new(21, 34);
        Time2 t4 = new(12, 25, 42);
        Time2 t5 = new(t4);

        var times = new (string label, Time2 time)[]
        {
            ("t1: all arguments defaulted", t1),
            ("t2: hour specified; minute and second defaulted", t2),
            ("t3: hour and minute specified; second defaulted", t3),
            ("t4: hour, minute and second specified", t4),
            ("t5: Time2 object t4 specified", t5)
        };

        Console.WriteLine("Constructed with:\n");

        foreach (var (label, time) in times)
        {
            Console.WriteLine(label);
            Console.WriteLine($"   Universal: {time.ToUniversalString()}");
            Console.WriteLine($"   Standard:  {time}\n");
        }

        try
        {
            Time2 t6 = new(27, 74, 99);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Exception while initializing t6:");
            Console.WriteLine(ex.Message);
        }
    }
}
