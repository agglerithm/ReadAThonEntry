using FluentNHibernate.Mapping;
using ReadAThonEntry.Core.DTOs;

namespace ReadAThonEntry.Core.Mappers
{
    public class ContactDtoMapper : ClassMap<ContactDto>
    {
        public ContactDtoMapper()
        {
            Table("Contacts");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.ShirtSize); 
            Map(x => x.Title);
            HasMany<StudentDto>(x => x.Students);
        }
    }
}