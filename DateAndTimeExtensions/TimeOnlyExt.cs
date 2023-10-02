namespace DateAndTimeExtensions;

public static class TimeOnlyExt
{
    public static TimeOnly Now => TimeOnly.FromDateTime(DateTime.Now);

    public static TimeOnly UtcNow => TimeOnly.FromDateTime(DateTime.UtcNow);

    public static TimeOnly Midday => TimeOnly.FromTimeSpan(TimeSpan.FromHours(12));
}