namespace DateAndTimeExtensions;

public static class TimeOnlyExt
{
    public static TimeOnly Now()
    {
        return TimeOnly.FromDateTime(DateTime.Now);
    }

    public static TimeOnly UtcNow()
    {
        return TimeOnly.FromDateTime(DateTime.UtcNow);
    }

    public static TimeOnly Midday()
    {
        return TimeOnly.FromTimeSpan(TimeSpan.FromHours(12));
    }
}