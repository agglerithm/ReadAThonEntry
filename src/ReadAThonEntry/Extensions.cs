namespace ReadAThonEntry
{
    using System;

    public static class Extensions
    {
        public static decimal HoursTo(this DateTime start, DateTime end)
        {
            return (decimal)((end.Ticks - start.Ticks) / TimeSpan.TicksPerMinute) / 60;
        }

 
 

        public static DateTime FirstDayOfMonth(this DateTime dte)
        {
            return DateTime.Parse(dte.Month + "/01/" + dte.Year);
        }

        public static DateTime LastDayOfMonth(this DateTime dte)
        {
            var nextMonth = FirstDayOfMonth(dte.AddMonths(1));
            return nextMonth.AddDays(-1);
        }
 
        public static string ReportTime(this DateTime dte)
        {
            return dte.ToString("hh:mm tt");
        }

        public static string ReportDate(this DateTime dte)
        {
            return dte.ToString("MMM dd, yyyy");
        }
    }
}