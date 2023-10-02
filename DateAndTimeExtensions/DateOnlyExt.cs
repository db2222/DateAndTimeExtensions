namespace DateAndTimeExtensions;

public static class DateOnlyExt
{
    public static DateOnly Today()
    {
        return DateOnly.FromDateTime(DateTime.Today);
    }

    public static DateOnly Tomorrow()
    {
        return Today().AddDays(1);
    }

    public static DateOnly Yesterday()
    {
        return Today().AddDays(-1);
    }

    public static DateOnly FirstOfMonth()
    {
        return FirstOfMonth(Today());
    }

    public static DateOnly FirstOfMonth(this DateOnly dateOnly)
    {
        return new DateOnly(dateOnly.Year, dateOnly.Month, 1);
    }

    public static DateOnly LastOfMonth()
    {
        return LastOfMonth(Today());
    }

    public static DateOnly LastOfMonth(this DateOnly dateOnly)
    {
        var day = DateTime.DaysInMonth(dateOnly.Year, dateOnly.Month);
        return new DateOnly(dateOnly.Year, dateOnly.Month, day);
    }

    public static DateOnly FirstOfYear()
    {
        return new DateOnly(DateTime.Today.Year, 1, 1);
    }

    public static DateOnly FirstOfYear(this DateOnly dateOnly)
    {
        return new DateOnly(dateOnly.Year, 1, 1);
    }

    public static DateOnly LastOfYear()
    {
        return new DateOnly(DateTime.Today.Year, 12, 31);
    }

    public static DateOnly LastOfYear(this DateOnly dateOnly)
    {
        return new DateOnly(dateOnly.Year, 12, 31);
    }

    public static bool IsWeekday()
    {
        return IsWeekday(Today());
    }

    public static bool IsWeekday(this DateOnly dateOnly)
    {
        return dateOnly.DayOfWeek != DayOfWeek.Saturday && dateOnly.DayOfWeek != DayOfWeek.Sunday;
    }

    public static bool IsWeekend()
    {
        return IsWeekend(Today());
    }

    public static bool IsWeekend(this DateOnly dateOnly)
    {
        return dateOnly.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;
    }

    public static DateOnly NextWorkday()
    {
        return NextWorkday(Today());
    }

    public static DateOnly NextWorkday(this DateOnly dateOnly)
    {
        do dateOnly = dateOnly.AddDays(1);
        while (IsWeekend(dateOnly));
        return dateOnly;
    }

    public static DateOnly PreviousWorkday()
    {
        return PreviousWorkday(Today());
    }

    public static DateOnly PreviousWorkday(this DateOnly dateOnly)
    {
        do dateOnly = dateOnly.AddDays(-1);
        while (IsWeekend(dateOnly));
        return dateOnly;
    }

    public static int DaysFromToday(this DateOnly dateOnly)
    {
        return dateOnly.DayNumber - Today().DayNumber;
    }

    public static int DaysSinceToday(this DateOnly dateOnly)
    {
        return Today().DayNumber - dateOnly.DayNumber;
    }
}