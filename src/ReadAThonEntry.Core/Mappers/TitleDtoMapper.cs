using FluentNHibernate.Mapping;
using ReadAThonEntry.Core.DTOs;

namespace ReadAThonEntry.Core.Mappers
{
    public class TitleDtoMapper : ClassMap<TitleDto>
    {
        public TitleDtoMapper()
        {
            Table("Titles");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.TitleName);
        }
    }
}