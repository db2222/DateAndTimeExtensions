namespace DateAndTimeExtensions;

public static class TimeOnly
{
    public static System.TimeOnly Now()
    {
        return System.TimeOnly.FromDateTime(System.DateTime.Now);
    }

    public static System.TimeOnly UtcNow()
    {
        return System.TimeOnly.FromDateTime(System.DateTime.UtcNow);
    }

    public static System.TimeOnly Midday()
    {
        return System.TimeOnly.FromTimeSpan(TimeSpan.FromHours(12));
    }
}