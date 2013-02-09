namespace ReadAThonEntry.Mappers
{
    using DTOs;
    using FluentNHibernate.Mapping;

    public class PledgeDtoMapper : ClassMap<PledgeDto>
    {
        public PledgeDtoMapper()
        {
            Table("Pledges");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.Name);
            Map(x => x.Minutes);
            Map(x => x.Pledge); 
        }
    }
}