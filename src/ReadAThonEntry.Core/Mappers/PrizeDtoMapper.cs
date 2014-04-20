using FluentNHibernate.Mapping;
using ReadAThonEntry.Core.DTOs;

namespace ReadAThonEntry.Core.Mappers
{
    public class PrizeDtoMapper : ClassMap<PrizeDto>
    {
        public PrizeDtoMapper()
        {
            Table("Prizes");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.MinAmount);
            Map(x => x.MaxAmount);
            Map(x => x.Description);
        }
    }
}