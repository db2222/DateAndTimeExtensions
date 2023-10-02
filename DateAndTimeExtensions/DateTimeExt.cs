namespace DateAndTimeExtensions;

public static class DateTimeExt
{
    public static DateTime Tomorrow => DateTime.Today.AddDays(1);

    public static DateTime TomorrowFromNow => DateTime.Now.AddDays(1);

    public static DateTime TomorrowFromUtcNow => DateTime.UtcNow.AddDays(1);

    public static DateTime Yesterday => DateTime.Today.AddDays(-1);

    public static DateTime YesterdayFromNow => DateTime.Now.AddDays(-1);

    public static DateTime YesterdayFromUtcNow => DateTime.UtcNow.AddDays(-1);

    public static DateTime StartOfDay(this DateTime dateTime)
    {
        return dateTime.Date + TimeSpan.Zero;
    }

    public static DateTime EndOfDay(this DateTime dateTime)
    {
        return dateTime.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
    }

    public static DateTime EndOfToday()
    {
        return EndOfDay(DateTime.Today);
    }

    public static DateTime StartOfMonth()
    {
        return StartOfMonth(DateTime.Today);
    }

    public static DateTime StartOfMonth(this DateTime dateTime)
    {
        return new DateTime(dateTime.Year, dateTime.Month, 1);
    }

    public static DateTime LastOfMonth()
    {
        return LastOfMonth(DateTime.Today);
    }

    public static DateTime LastOfMonth(this DateTime dateTime)
    {
        var day = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
        return new DateTime(dateTime.Year, dateTime.Month, day);
    }

    public static DateTime EndOfMonth()
    {
        return EndOfMonth(DateTime.Today);
    }

    public static DateTime EndOfMonth(this DateTime dateTime)
    {
        var day = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
        return new DateTime(dateTime.Year, dateTime.Month, day, 23, 59, 59);
    }

    public static DateTime StartOfYear()
    {
        return StartOfYear(DateTime.Today);
    }

    public static DateTime StartOfYear(this DateTime dateTime)
    {
        return new DateTime(dateTime.Year, 1, 1);
    }

    public static DateTime LastOfYear()
    {
        return LastOfYear(DateTime.Today);
    }

    public static DateTime LastOfYear(this DateTime dateTime)
    {
        return new DateTime(dateTime.Year, 12, 31);
    }

    public static DateTime EndOfYear()
    {
        return EndOfYear(DateTime.Today);
    }

    public static DateTime EndOfYear(this DateTime dateTime)
    {
        return new DateTime(dateTime.Year, 12, 31, 23, 59, 59);
    }

    public static bool IsWeekday()
    {
        return IsWeekday(DateTime.Today);
    }

    public static bool IsWeekday(this DateTime dateTime)
    {
        return dateTime.DayOfWeek != DayOfWeek.Saturday && dateTime.DayOfWeek != DayOfWeek.Sunday;
    }

    public static bool IsWeekend()
    {
        return IsWeekend(DateTime.Today);
    }

    public static bool IsWeekend(this DateTime dateTime)
    {
        return dateTime.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;
    }

    public static DateTime NextWorkday()
    {
        return NextWorkday(DateTime.Today);
    }

    public static DateTime NextWorkday(this DateTime dateTime)
    {
        do dateTime = dateTime.AddDays(1);
        while (IsWeekend(dateTime));
        return dateTime;
    }

    public static DateTime PreviousWorkday()
    {
        return PreviousWorkday(DateTime.Today);
    }

    public static DateTime PreviousWorkday(this DateTime dateTime)
    {
        do dateTime = dateTime.AddDays(-1);
        while (IsWeekend(dateTime));
        return dateTime;
    }

    public static int DaysFromToday(this DateTime dateTime)
    {
        return (dateTime - DateTime.Today).Days;
    }

    public static int DaysSinceToday(this DateTime dateTime)
    {
        return (DateTime.Today - dateTime).Days;
    }

    public static int DaysFromNow(this DateTime dateTime)
    {
        return (dateTime - DateTime.Now).Days;
    }

    public static int DaysSinceNow(this DateTime dateTime)
    {
        return (DateTime.Now - dateTime).Days;
    }

    public static int DaysFromUtcNow(this DateTime dateTime)
    {
        return (dateTime - DateTime.UtcNow).Days;
    }

    public static int DaysSinceUtcNow(this DateTime dateTime)
    {
        return (DateTime.UtcNow - dateTime).Days;
    }

    public static DateTime SetTime(this DateTime dateTime, int hours, int minutes = 0, int seconds = 0, int milliseconds = 0)
    {
        var timespan = new TimeSpan(0, hours, minutes, seconds, milliseconds);
        return dateTime.Date + timespan;
    }
}