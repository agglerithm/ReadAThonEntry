namespace ReadAThonEntry.Core.Mappers
{
    using ReadAThonEntry.Core.DTOs;
    using FluentNHibernate.Mapping;

    public class StudentDtoMapper : ClassMap<StudentDto>
    {
        public StudentDtoMapper()
        {
            Table("Students");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Address1);
            Map(x => x.Address2);
            Map(x => x.City);
            Map(x => x.State);
            Map(x => x.Zip);
            Map(x => x.AmountFromEnvelope);
            Map(x => x.AmountFromWebsite);
            Map(x => x.Phone);
            Map(x => x.ShirtSize);
            Map(x => x.TeacherId);
            Map(x => x.Grade);
            Map(x => x.MinutesRead);
            Map(x => x.PagesRead);
            Map(x => x.Comments);
            Map(x => x.EnvelopeNumber);
            Map(x => x.YearOf);
            Map(x => x.SchoolName);
            Map(x => x.FundraisingGoal);
            Map(x => x.ReadingGoal);
        }
    }
}