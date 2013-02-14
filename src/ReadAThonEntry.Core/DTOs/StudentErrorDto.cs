namespace ReadAThonEntry.Core.DTOs
{
    using System;

    public class StudentErrorDto : StudentDto
    {
        public StudentErrorDto(StudentDto source, Exception ex)
        {
            Address1 = source.Address1;
            Address2 = source.Address2;
            AmountFromWebsite = source.AmountFromWebsite;
            School = source.School;
            FirstName = source.FirstName;
            LastName = source.LastName;
            Teacher = source.Teacher;
            City = source.City;
            State = source.State;
            Zip = source.Zip;
            Phone = source.Phone;
            Grade = source.Grade;
            ErrorMsg = ex.ToString();
        }

        public StudentErrorDto()
        {
        }

        public virtual string ErrorMsg { get; set; }
    }
}