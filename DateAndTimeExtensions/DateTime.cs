namespace DateAndTimeExtensions;

public static class DateTime
{
    public static System.DateTime Tomorrow()
    {
        return System.DateTime.Today.AddDays(1);
    }

    public static System.DateTime TomorrowFromNow()
    {
        return System.DateTime.Now.AddDays(1);
    }

    public static System.DateTime TomorrowFromUtcNow()
    {
        return System.DateTime.UtcNow.AddDays(1);
    }

    public static System.DateTime Yesterday()
    {
        return System.DateTime.Today.AddDays(-1);
    }

    public static System.DateTime YesterdayFromNow()
    {
        return System.DateTime.Now.AddDays(-1);
    }

    public static System.DateTime YesterdayFromUtcNow()
    {
        return System.DateTime.UtcNow.AddDays(-1);
    }

    public static System.DateTime StartOfDay(this System.DateTime dateTime)
    {
        return dateTime.Date + TimeSpan.Zero;
    }

    public static System.DateTime EndOfDay(this System.DateTime dateTime)
    {
        return dateTime.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
    }

    public static System.DateTime EndOfToday()
    {
        return EndOfDay(System.DateTime.Today);
    }

    public static System.DateTime StartOfMonth()
    {
        return StartOfMonth(System.DateTime.Today);
    }

    public static System.DateTime StartOfMonth(this System.DateTime dateTime)
    {
        return new System.DateTime(dateTime.Year, dateTime.Month, 1);
    }

    public static System.DateTime LastOfMonth()
    {
        return LastOfMonth(System.DateTime.Today);
    }

    public static System.DateTime LastOfMonth(this System.DateTime dateTime)
    {
        var day = System.DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
        return new System.DateTime(dateTime.Year, dateTime.Month, day);
    }

    public static System.DateTime EndOfMonth()
    {
        return EndOfMonth(System.DateTime.Today);
    }

    public static System.DateTime EndOfMonth(this System.DateTime dateTime)
    {
        var day = System.DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
        return new System.DateTime(dateTime.Year, dateTime.Month, day, 23, 59, 59);
    }

    public static System.DateTime StartOfYear()
    {
        return StartOfYear(System.DateTime.Today);
    }

    public static System.DateTime StartOfYear(this System.DateTime dateTime)
    {
        return new System.DateTime(dateTime.Year, 1, 1);
    }

    public static System.DateTime LastOfYear()
    {
        return LastOfYear(System.DateTime.Today);
    }

    public static System.DateTime LastOfYear(this System.DateTime dateTime)
    {
        return new System.DateTime(dateTime.Year, 12, 31);
    }

    public static System.DateTime EndOfYear()
    {
        return EndOfYear(System.DateTime.Today);
    }

    public static System.DateTime EndOfYear(this System.DateTime dateTime)
    {
        return new System.DateTime(dateTime.Year, 12, 31, 23, 59, 59);
    }

    public static bool IsWeekday(this System.DateTime dateTime)
    {
        return dateTime.DayOfWeek != DayOfWeek.Saturday && dateTime.DayOfWeek != DayOfWeek.Sunday;
    }

    public static bool IsWeekend(this System.DateTime dateTime)
    {
        return dateTime.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;
    }

    public static System.DateTime NextWorkday(this System.DateTime dateTime)
    {
        do dateTime = dateTime.AddDays(1);
        while (IsWeekend(dateTime));
        return dateTime;
    }

    public static System.DateTime PreviousWorkday(this System.DateTime dateTime)
    {
        do dateTime = dateTime.AddDays(-1);
        while (IsWeekend(dateTime));
        return dateTime;
    }

    public static int DaysFromToday(this System.DateTime dateTime)
    {
        return (dateTime - System.DateTime.Today).Days;
    }

    public static int DaysSinceToday(this System.DateTime dateTime)
    {
        return (System.DateTime.Today - dateTime).Days;
    }

    public static int DaysFromNow(this System.DateTime dateTime)
    {
        return (dateTime - System.DateTime.Now).Days;
    }

    public static int DaysSinceNow(this System.DateTime dateTime)
    {
        return (System.DateTime.Now - dateTime).Days;
    }

    public static int DaysFromUtcNow(this System.DateTime dateTime)
    {
        return (dateTime - System.DateTime.UtcNow).Days;
    }

    public static int DaysSinceUtcNow(this System.DateTime dateTime)
    {
        return (System.DateTime.UtcNow - dateTime).Days;
    }

    public static System.DateTime SetTime(this System.DateTime dateTime, int hours, int minutes, int seconds = 0, int milliseconds = 0)
    {
        var timespan = new TimeSpan(0, hours, minutes, seconds, milliseconds);
        return dateTime.Date + timespan;
    }
}