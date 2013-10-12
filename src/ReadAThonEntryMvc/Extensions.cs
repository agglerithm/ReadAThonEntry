using System;
using CJR.Common.Extensions;
using ReadAThonEntry.Core.DTOs;
using ReadAThonEntryMvc.Models;

namespace ReadAThonEntryMvc
{
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
                           ShirtSize = student.ShirtSize,
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

//        public static ShirtSize GetEnumValue(this string val)
//        {
//            if(val == "YouthSmall") return "YouthSmall;
//            if(val == "YouthMedium") return "YouthMedium;
//            if(val == "YouthLarge") return "YouthLarge;
//            if(val == "YouthXl") return "YouthXl;
//            if(val == "AdultSmall") return "AdultSmall;
//            if(val == "AdultMedium") return "AdultMedium;
//            if(val == "AdultLarge") return "AdultLarge;
//            if (val.IsNullOrEmpty() && val == "None") return "None;
//            return "AdultXl;
//        }
//
//        public static string GetStringValue(this ShirtSize size)
//        {
//            return typeof (ShirtSize).GetEnumName(size);
//        }

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
                           ShirtSize = student.ShirtSize,
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
                ShirtSize = student.ShirtSize,
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
 
        public static bool StartsLike(this string source, string target)
        {
            return source.ToUpper().StartsWith(target.ToUpper());
        }
        public static string ReportTime(this DateTime dte)
        {
            return dte.ToString("hh:mm tt");
        }

        public static string ReportDate(this DateTime dte)
        {
            return dte.ToString("MMM dd, yyyy");
        }
        public static StudentDto MergeWithPrototype(this StudentPrototype student, StudentDto dto)
        {
            dto.AmountFromEnvelope = student.AmountFromEnvelope.CastToDecimal();
            dto.AmountFromWebsite = student.AmountFromWebsite.CastToDecimal();
            dto.FundraisingGoal = student.FundraisingGoal.CastToDecimal();
            dto.EnvelopeNumber = student.EnvelopeNumber;
            dto.FirstName = student.FirstName;
            dto.LastName = student.LastName;
            dto.Grade = student.Grade;
            dto.MinutesRead = student.MinutesRead.CastToInt();
            dto.PagesRead = student.PagesRead.CastToInt();
            dto.ReadingGoal = student.ReadingGoal.CastToInt();
            dto.School = student.School;
            dto.ShirtSize = student.ShirtSize;
            dto.Address1 = student.Address1;
            dto.Address2 = student.Address2;
            dto.City = student.City;
            dto.State = student.State;
            dto.Zip = student.Zip;
            dto.Phone = student.Phone;
            dto.Teacher = student.Teacher;
            return dto;
        }
    }
}