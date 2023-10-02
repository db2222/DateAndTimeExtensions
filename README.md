# DateAndTimeExtensions (C#)
Available via Nuget: https://www.nuget.org/packages/DateAndTimeExtensions \
\
Little convenience helper extension methods for:
- `DateTime`
- `DateOnly`
- `TimeOnly`

There are 2 type of extensions:
- instance (parameter `this`)
- class

However, C# doesn't allow to extend static classes themselves. \
This is why for easier usage the extension classes are named exactly as their .NET counterparts. \
Just include the namespace `DateAndTimeExtensions`.

# Extension methods
## DateTime
- DaysFromNow(this DateTime dateTime):int
- DaysFromToday(this DateTime dateTime):int
- DaysFromUtcNow(this DateTime dateTime):int
- DaysSinceNow(this DateTime dateTime):int
- DaysSinceToday(this DateTime dateTime):int
- DaysSinceUtcNow(this DateTime dateTime):int
- EndOfDay(this DateTime dateTime):DateTime
- EndOfMonth():DateTime
- EndOfMonth(this DateTime dateTime):DateTime
- EndOfToday():DateTime
- EndOfYear():DateTime
- EndOfYear(this DateTime dateTime):DateTime
- IsWeekday(this DateTime dateTime):bool
- IsWeekend(this DateTime dateTime):bool
- LastOfMonth():DateTime
- LastOfMonth(this DateTime dateTime):DateTime
- LastOfYear():DateTime
- LastOfYear(this DateTime dateTime):DateTime
- NextWorkday(this DateTime dateTime):DateTime
- PreviousWorkday(this DateTime dateTime):DateTime
- SetTime(this DateTime dateTime, int hours, int minutes, int seconds = 0, int milliseconds = 0):DateTime
- StartOfDay(this DateTime dateTime):DateTime
- StartOfMonth():DateTime
- StartOfMonth(this DateTime dateTime):DateTime
- StartOfYear():DateTime
- StartOfYear(this DateTime dateTime):DateTime
- Tomorrow():DateTime
- TomorrowFromNow():DateTime
- TomorrowFromUtcNow():DateTime
- Yesterday():DateTime
- YesterdayFromNow():DateTime
- YesterdayFromUtcNow():DateTime

## DateOnly
- DaysFromToday(this DateOnly dateOnly):int
- DaysSinceToday(this DateOnly dateOnly):int
- FirstOfMonth():DateOnly
- FirstOfMonth(this DateOnly dateOnly):DateOnly
- FirstOfYear():DateOnly
- FirstOfYear(this DateOnly dateOnly):DateOnly
- IsWeekday(this DateOnly dateOnly):bool
- IsWeekend(this DateOnly dateOnly):bool
- LastOfMonth():DateOnly
- LastOfMonth(this DateOnly dateOnly):DateOnly
- LastOfYear():DateOnly
- LastOfYear(this DateOnly dateOnly):DateOnly
- NextWorkday(this DateOnly dateOnly):DateOnly
- PreviousWorkday(this DateOnly dateOnly):DateOnly
- Today():DateOnly
- Tomorrow():DateOnly
- Yesterday():DateOnly

## TimeOnly
- Midday():TimeOnly
- Now():TimeOnly
- UtcNow():TimeOnly