namespace TimeKeeper.Mappers
{
    using DTOs;
    using FluentNHibernate.Mapping;
    using ReadAThonEntry.DTOs;

    public class TimeBlockMapper : ClassMap<ReaderDto>
    {
        public TimeBlockMapper()
        {
            Table("TimeBlocks");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.StartTime);
            Map(x => x.EndTime);
            Map(x => x.Comments);
            References(x => x.Department).Column("Dept_Id"); 
        }
    }
}
