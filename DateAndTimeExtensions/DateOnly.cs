namespace DateAndTimeExtensions;

public static class DateOnly
{
    public static System.DateOnly Today()
    {
        return System.DateOnly.FromDateTime(System.DateTime.Today);
    }

    public static System.DateOnly Tomorrow()
    {
        return Today().AddDays(1);
    }

    public static System.DateOnly Yesterday()
    {
        return Today().AddDays(-1);
    }

    public static System.DateOnly FirstOfMonth()
    {
        return FirstOfMonth(Today());
    }

    public static System.DateOnly FirstOfMonth(this System.DateOnly dateOnly)
    {
        return new System.DateOnly(dateOnly.Year, dateOnly.Month, 1);
    }

    public static System.DateOnly LastOfMonth()
    {
        return LastOfMonth(Today());
    }

    public static System.DateOnly LastOfMonth(this System.DateOnly dateOnly)
    {
        var day = System.DateTime.DaysInMonth(dateOnly.Year, dateOnly.Month);
        return new System.DateOnly(dateOnly.Year, dateOnly.Month, day);
    }

    public static System.DateOnly FirstOfYear()
    {
        return new System.DateOnly(System.DateTime.Today.Year, 1, 1);
    }

    public static System.DateOnly FirstOfYear(this System.DateOnly dateOnly)
    {
        return new System.DateOnly(dateOnly.Year, 1, 1);
    }

    public static System.DateOnly LastOfYear()
    {
        return new System.DateOnly(System.DateTime.Today.Year, 12, 31);
    }

    public static System.DateOnly LastOfYear(this System.DateOnly dateOnly)
    {
        return new System.DateOnly(dateOnly.Year, 12, 31);
    }

    public static bool IsWeekday(this System.DateOnly dateOnly)
    {
        return dateOnly.DayOfWeek != DayOfWeek.Saturday && dateOnly.DayOfWeek != DayOfWeek.Sunday;
    }

    public static bool IsWeekend(this System.DateOnly dateOnly)
    {
        return dateOnly.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;
    }

    public static System.DateOnly NextWorkday(this System.DateOnly dateOnly)
    {
        do dateOnly = dateOnly.AddDays(1);
        while (IsWeekend(dateOnly));
        return dateOnly;
    }

    public static System.DateOnly PreviousWorkday(this System.DateOnly dateOnly)
    {
        do dateOnly = dateOnly.AddDays(-1);
        while (IsWeekend(dateOnly));
        return dateOnly;
    }

    public static int DaysFromToday(this System.DateOnly dateOnly)
    {
        return dateOnly.DayNumber - Today().DayNumber;
    }

    public static int DaysSinceToday(this System.DateOnly dateOnly)
    {
        return Today().DayNumber - dateOnly.DayNumber;
    }
}