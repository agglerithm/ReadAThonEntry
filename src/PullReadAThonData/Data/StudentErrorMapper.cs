using FluentNHibernate.Mapping;

namespace PullReadAThonData.Data
{
    public class StudentErrorMapper : ClassMap<StudentErrorDto>

    {
        public StudentErrorMapper()
        {
            Table("StudentErrors");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.LastName);
            Map(x => x.FirstName);
            Map(x => x.Grade);
            Map(x => x.School);
            Map(x => x.Teacher);
            Map(x => x.ErrorMsg);
            Map(x => x.FundraisingGoal);
            Map(x => x.AmountFromEnvelope);
            Map(x => x.AmountFromWebsite);
            Map(x => x.Address1);
            Map(x => x.Address2);
            Map(x => x.City);
            Map(x => x.State);
            Map(x => x.Zip);
            Map(x => x.Comments);
            Map(x => x.EnvelopeNumber);
        }
    }
    public class StudentDownloadMapper : ClassMap<StudentDownloadDto>
    {
        public StudentDownloadMapper()
        {
            Table("StudentDownloads");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.LastName);
            Map(x => x.FirstName);
            Map(x => x.Grade);
            Map(x => x.School);
            Map(x => x.Teacher); 
            Map(x => x.FundraisingGoal);
            Map(x => x.AmountFromEnvelope);
            Map(x => x.AmountFromWebsite);
            Map(x => x.Address1);
            Map(x => x.Address2);
            Map(x => x.City);
            Map(x => x.State);
            Map(x => x.Zip);
            Map(x => x.Comments);
            Map(x => x.EnvelopeNumber);
        }
    }
}