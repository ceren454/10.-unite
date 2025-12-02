using System;

public class Time1
{
    private int hour;  
    private int minute; 
    private int second; 

    public int Hour
    {
        get => hour;
        set
        {
            if (value < 0 || value > 23) throw new ArgumentOutOfRangeException(nameof(Hour));
            hour = value;
        }
    }

    public int Minute
    {
        get => minute;
        set
        {
            if (value < 0 || value > 59) throw new ArgumentOutOfRangeException(nameof(Minute));
            minute = value;
        }
    }

    public int Second
    {
        get => second;
        set
        {
            if (value < 0 || value > 59) throw new ArgumentOutOfRangeException(nameof(Second));
            second = value;
        }
    }

    public Time1(int hour = 0, int minute = 0, int second = 0)
    {
        SetTime(hour, minute, second);
    }

    public void SetTime(int h, int m, int s)
    {
        Hour = h;
        Minute = m;
        Second = s;
    }

    public string ToUniversalString() => $"{Hour:D2}:{Minute:D2}:{Second:D2}";

    public override string ToString()
    {
        int displayHour = (Hour % 12 == 0) ? 12 : Hour % 12;
        string amPm = (Hour < 12) ? "AM" : "PM";
        return $"{displayHour}:{Minute:D2}:{Second:D2} {amPm}";
    }
}

class Program
{
    static void Main()
    {
        Time1 time = new Time1();
        time.SetTime(13, 5, 7);

        Console.WriteLine(time.ToUniversalString()); 
        Console.WriteLine(time);                     
    }
}
