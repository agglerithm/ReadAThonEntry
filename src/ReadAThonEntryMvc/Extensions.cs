using System;
using System.Collections.Generic;
using System.Linq;
using CJR.Common.Extensions;
using ReadAThonEntry.Core.DTOs;
using ReadAThonEntryMvc.Models;
using ReadAThonEntryMvc.Services;

namespace ReadAThonEntryMvc
{
    public static class Extensions
    {
        public static decimal HoursTo(this DateTime start, DateTime end)
        {
            return (decimal)((end.Ticks - start.Ticks) / TimeSpan.TicksPerMinute) / 60;
        }

        public static Student MapToModel(this StudentDto student, ContactDto teacher)
        {
            var stu = new Student()
                       {
                           Id = student.Id,
                           AmountFromEnvelope = student.AmountFromEnvelope,
                           AmountFromWebsite = student.AmountFromWebsite,
                           Comments = student.Comments,
                           EnvelopeNumber = student.EnvelopeNumber,
                           FirstName = student.FirstName,
                           LastName = student.LastName,
                           Grade = student.Grade,
                           MinutesRead = student.MinutesRead,
                           PagesRead = student.PagesRead, 
                           SchoolName = student.SchoolName,
                           ShirtSize = student.ShirtSize,
                           Address1 = student.Address1,
                           Address2 = student.Address2,
                           City = student.City,
                           State = student.State,
                           Zip = student.Zip,
                           Phone = student.Phone,
                           TeacherId = student.TeacherId, 
                           ReadingGoal = student.ReadingGoal,
                           FundraisingGoal = student.FundraisingGoal,
                           
                       };
            if (teacher != null)
                stu.TeacherName = teacher.LastName;
            return stu;
        }

        public static string DisplayName(this ContactDto teacher)
        {
            if (teacher.FirstName == null)
                return teacher.LastName;
            return teacher.LastName + ", " + teacher.FirstName;
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

//        public static StudentDto MapFromModel(this Student student)
//        {
//            return new StudentDto()
//                       {
//                           AmountFromEnvelope = student.AmountFromEnvelope,
//                           AmountFromWebsite = student.AmountFromWebsite,
//                           Comments = student.Comments,
//                           EnvelopeNumber = student.EnvelopeNumber,
//                           FirstName = student.FirstName,
//                           LastName = student.LastName,
//                           Grade = student.Grade,
//                           MinutesRead = student.MinutesRead,
//                           PagesRead = student.PagesRead, 
//                           ShirtSize = student.ShirtSize,
//                Address1 = student.Address1,
//                Address2 = student.Address2,
//                City = student.City,
//                State = student.State,
//                Zip = student.Zip,
//                Phone = student.Phone, 
//            };
//        }

//        public static StudentDto MapToDto(this Student student)
//        {
//            return new StudentDto()
//                {
//                    Address1 = student.Address1,
//                    Address2 = student.Address2,
//                    AmountFromEnvelope = student.AmountFromEnvelope,
//                    AmountFromWebsite = student.AmountFromWebsite,
//                    City = student.City,
//                    Comments = student.Comments,
//                    EnvelopeNumber = student.EnvelopeNumber,
//                    FirstName = student.FirstName,
//                    LastName = student.LastName,
//                    FundraisingGoal = student.FundraisingGoal,
//                    Grade = student.Grade,
//                    ReadingGoal = student.ReadingGoal,
//                    MinutesRead = student.MinutesRead,
//                    PagesRead = student.PagesRead,
//                    Phone = student.Phone,
//                    Prizes = student.Prizes.Select(MapToPrizeDto).ToList(), 
//                };
//        }

        private static ContactDto MapToContactDto(this Contact contact)
        {
            return new ContactDto()
                {
                    FirstName = contact.FirstName,
                    LastName = contact.LastName,
                    Id = contact.Id,
                    ShirtSize = contact.ShirtSize,
                    Title = contact.Title 
                };
        }

        public static SchoolDto MapToSchoolDto(this School school)
        {
            return new SchoolDto()
                {
                    Name = school.Name,
                    Address1 = school.Address1,
                    Address2 = school.Address2,
                    City = school.City,
                    State = school.State,
                    Zip = school.Zip,
                    NumberOfClassrooms = school.NumberOfClassrooms,
                    Contacts = school.Contacts.Select(MapToContactDto).ToList()
                };
        }
        private static PrizeDto MapToPrizeDto(Prize pr)
        {
            return new PrizeDto()
                {
                    Description = pr.Description,
                    Id = pr.Id,
                    MaxAmount = pr.MaxAmount,
                    MinAmount = pr.MinAmount
                };
        }

        public static StudentDto MapFromPrototype(this StudentPrototype student, IStudentMappingHelper helper)
        {
            var dto = new StudentDto()
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
                SchoolName = helper.School.Name, 
                ShirtSize = student.ShirtSize,
                Address1 = student.Address1,
                Address2 = student.Address2,
                City = student.City,
                State = student.State,
                Zip = student.Zip,
                Phone = student.Phone 
            };
            if (helper.Teacher != null)
            { 
                dto.TeacherId = helper.Teacher.Id;
            }
            return dto;
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
            return source != null && source.ToUpper().StartsWith(target.ToUpper());
        }

        public static string ReportTime(this DateTime dte)
        {
            return dte.ToString("hh:mm tt");
        }

        public static string ReportDate(this DateTime dte)
        {
            return dte.ToString("MMM dd, yyyy");
        }
        
        public static School MapToModel(this SchoolDto school, bool LazyLoad)
        {
            return new School
                {
                    Id = (int)school.Id,
                    Name = school.Name,
                    Address1 = school.Address1,
                    City = school.City,
                    State = school.State,
                    Zip = school.Zip,
                    NumberOfClassrooms =  school.NumberOfClassrooms,
                    Contacts = getContacts(school,school.Contacts, LazyLoad)
                };
        }

        public static Contact MapToModel(this ContactDto contact, SchoolDto parent)
        {
            return new Contact
                {
                    Title = contact.Title,
                    FirstName = contact.FirstName,
                    LastName = contact.LastName, 
                    Id = contact.Id,
                    School = parent.Name,
                    SchoolId = parent.Id
                };
        }
        
        private static IEnumerable<Contact> getContacts(SchoolDto parent, IList<ContactDto> contacts, bool LazyLoad)
        {
            return LazyLoad ? null : contacts.Select(c => c.MapToModel(parent));
        }

        public static StudentDto MergeWithModel(this Student student, StudentDto dto, 
            IStudentMappingHelper helper)
        {
            dto.Id = student.Id;
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
            dto.SchoolName = helper.School.Name;
            dto.ShirtSize = student.ShirtSize;
            dto.Address1 = student.Address1;
            dto.Address2 = student.Address2;
            dto.City = student.City;
            dto.State = student.State;
            dto.Zip = student.Zip;
            dto.Phone = student.Phone; 
            dto.TeacherId = helper.Teacher.Id;
            dto.Comments = student.Comments;
            return dto;
        }
    }
}