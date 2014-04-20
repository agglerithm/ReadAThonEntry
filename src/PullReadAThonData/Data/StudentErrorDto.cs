using System;
using ReadAThonEntry.Core.DTOs;

namespace PullReadAThonData.Data
{
    public class StudentErrorDto : StudentDto
    {
        public StudentErrorDto(StudentDto source, ContactDto teacher, Exception ex)
        {
            Address1 = source.Address1;
            Address2 = source.Address2;
            AmountFromWebsite = source.AmountFromWebsite; 
            FirstName = source.FirstName;
            LastName = source.LastName; 
            City = source.City;
            State = source.State;
            Zip = source.Zip;
            Phone = source.Phone;
            Grade = source.Grade;
            ErrorMsg = ex.ToString();
            School = source.SchoolName;
            Teacher = string.Format("{0} {1}", teacher.FirstName, teacher.LastName).Trim();
        }

        public StudentErrorDto()
        {
        }
        public virtual new string School { get; set; }
        public virtual new string Teacher { get; set; }
        public virtual string ErrorMsg { get; set; }
    }

    public class StudentDownloadDto : StudentDto
    {
        public StudentDownloadDto(StudentDto source, ContactDto teacher)
        {
            Address1 = source.Address1;
            Address2 = source.Address2;
            AmountFromWebsite = source.AmountFromWebsite;
            FirstName = source.FirstName;
            LastName = source.LastName;
            City = source.City;
            State = source.State;
            Zip = source.Zip;
            Phone = source.Phone;
            Grade = source.Grade; 
            School = source.SchoolName;
            Teacher = string.Format("{0} {1}", teacher.FirstName, teacher.LastName).Trim();
        }

        public StudentDownloadDto()
        {
        }
        public virtual new string School { get; set; }
        public virtual new string Teacher { get; set; } 
    }
}