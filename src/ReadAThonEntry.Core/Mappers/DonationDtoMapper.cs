namespace ReadAThonEntry.Mappers
{
    using DTOs;
    using FluentNHibernate.Mapping;

    public class DonationDtoMapper : ClassMap<DonationDto>
    {
        public DonationDtoMapper()
        {
            Table("Donations");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.Address1);
            Map(x => x.Address2);
            Map(x => x.Amount);
            Map(x => x.City);
            Map(x => x.State);
            Map(x => x.Zip);
            Map(x => x.Email);
            Map(x => x.FirstName);
            Map(x => x.LastName);
        }
    }
}