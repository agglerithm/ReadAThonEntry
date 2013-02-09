namespace ReadAThonEntry.Mappers
{
    using FluentNHibernate.Mapping;
    using DTOs;

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