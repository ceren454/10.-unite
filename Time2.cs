using System;

public class Time2
{
    private int hour;
    private int minute;
    private int second;

    public Time2(int h = 0, int m = 0, int s = 0) => SetTime(h, m, s);

    public Time2(Time2 t) : this(t.Hour, t.Minute, t.Second) { }

    public void SetTime(int h, int m, int s)
    {
        Hour = h;
        Minute = m;
        Second = s;
    }

    public int Hour
    {
        get => hour;
        set
        {
            if (value < 0 || value > 23)
                throw new ArgumentOutOfRangeException(nameof(value), value, "Hour must be 0-23");
            hour = value;
        }
    }

    public int Minute
    {
        get => minute;
        set
        {
            if (value < 0 || value > 59)
                throw new ArgumentOutOfRangeException(nameof(value), value, "Minute must be 0-59");
            minute = value;
        }
    }

    public int Second
    {
        get => second;
        set
        {
            if (value < 0 || value > 59)
                throw new ArgumentOutOfRangeException(nameof(value), value, "Second must be 0-59");
            second = value;
        }
    }

    public string ToUniversalString() => $"{Hour:D2}:{Minute:D2}:{Second:D2}";

    public override string ToString()
    {
        int standardHour = (Hour == 0 || Hour == 12) ? 12 : Hour % 12;
        string period = (Hour < 12) ? "AM" : "PM";
        return $"{standardHour}:{Minute:D2}:{Second:D2} {period}";
    }
}
