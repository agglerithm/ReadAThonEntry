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
            Map(x => x.Address1);
            Map(x => x.Address2);
            Map(x => x.City);
            Map(x => x.State);
            Map(x => x.Zip);
            Map(x => x.Phone);
            Map(x => x.NumberOfClassrooms);
            HasMany<ContactDto>(x => x.Contacts);

        }
    }
}