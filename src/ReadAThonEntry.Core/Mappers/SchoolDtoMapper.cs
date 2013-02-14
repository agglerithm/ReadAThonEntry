namespace ReadAThonEntry.Core.Mappers
{
    using ReadAThonEntry.Core.DTOs;
    using FluentNHibernate.Mapping;

    public class SchoolDtoMapper : ClassMap<SchoolDto>
    {
        public SchoolDtoMapper()
        {   
            Table("Schools");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.Name); 

        }
    }
}