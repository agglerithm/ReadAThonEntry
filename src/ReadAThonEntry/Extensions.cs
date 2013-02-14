namespace ReadAThonEntry
{
    using System;
    using CJR.Common.Extensions;
    using Core.DTOs; 
    using Nancy;
    using ViewModels;

    public static class Extensions
    {
        public static decimal HoursTo(this DateTime start, DateTime end)
        {
            return (decimal)((end.Ticks - start.Ticks) / TimeSpan.TicksPerMinute) / 60;
        }

        public static Student MapToModel(this StudentDto student)
        {
            return new Student()
                       {
                           AmountFromEnvelope = student.AmountFromEnvelope,
                           AmountFromWebsite = student.AmountFromWebsite,
                           Comments = student.Comments,
                           EnvelopeNumber = student.EnvelopeNumber,
                           FirstName = student.FirstName,
                           LastName = student.LastName,
                           Grade = student.Grade,
                           MinutesRead = student.MinutesRead,
                           PagesRead = student.PagesRead,
                           School = student.School,
                           ShirtSize = student.ShirtSize.GetEnumValue(),
                           Address1 = student.Address1,
                           Address2 = student.Address2,
                           City = student.City,
                           State = student.State,
                           Zip = student.Zip,
                           Phone = student.Phone,
                           Teacher = student.Teacher,
                           ReadingGoal = student.ReadingGoal,
                           FundraisingGoal = student.FundraisingGoal
                       };
        }

        public static ShirtSize GetEnumValue(this string val)
        {
            if(val == "YouthSmall") return ShirtSize.YouthSmall;
            if(val == "YouthMedium") return ShirtSize.YouthMedium;
            if(val == "YouthLarge") return ShirtSize.YouthLarge;
            if(val == "YouthXl") return ShirtSize.YouthXl;
            if(val == "AdultSmall") return ShirtSize.AdultSmall;
            if(val == "AdultMedium") return ShirtSize.AdultMedium;
            if(val == "AdultLarge") return ShirtSize.AdultLarge;
            if (val.IsNullOrEmpty()) return ShirtSize.None;
            return ShirtSize.AdultXl;
        }

        public static string GetStringValue(this ShirtSize size)
        {
            return typeof (ShirtSize).GetEnumName(size);
        }

        public static StudentDto MapFromModel(this Student student)
        {
            return new StudentDto()
                       {
                           AmountFromEnvelope = student.AmountFromEnvelope,
                           AmountFromWebsite = student.AmountFromWebsite,
                           Comments = student.Comments,
                           EnvelopeNumber = student.EnvelopeNumber,
                           FirstName = student.FirstName,
                           LastName = student.LastName,
                           Grade = student.Grade,
                           MinutesRead = student.MinutesRead,
                           PagesRead = student.PagesRead,
                           School = student.School,
                           ShirtSize = student.ShirtSize.GetStringValue(),
                Address1 = student.Address1,
                Address2 = student.Address2,
                City = student.City,
                State = student.State,
                Zip = student.Zip,
                Phone = student.Phone,
                Teacher = student.Teacher,
            };
        }

        public static StudentDto MapFromPrototype(this StudentPrototype student)
        {
            return new StudentDto()
            {
                AmountFromEnvelope = student.AmountFromEnvelope.CastToDecimal(),
                AmountFromWebsite = student.AmountFromWebsite.CastToDecimal(),
                FundraisingGoal = student.FundraisingGoal.CastToDecimal(),
                Comments = student.Comments,
                EnvelopeNumber = student.EnvelopeNumber,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Grade = student.Grade,
                MinutesRead = student.MinutesRead.CastToInt(),
                PagesRead = student.PagesRead.CastToInt(),
                ReadingGoal = student.ReadingGoal.CastToInt(),
                School = student.School,
                ShirtSize = student.ShirtSize.GetStringValue(),
                Address1 = student.Address1,
                Address2 = student.Address2,
                City = student.City,
                State = student.State,
                Zip = student.Zip,
                Phone = student.Phone,
                Teacher = student.Teacher,
            };
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