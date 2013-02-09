namespace TimeKeeper.Mappers
{
    using DTOs;
    using FluentNHibernate.Mapping;
    using ReadAThonEntry.DTOs;

    public class InvoiceMapper : ClassMap<PledgeDto>
    {
        public InvoiceMapper()
        {
            Table("Invoices");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.InvoiceDate);
            Map(x => x.TotalAmount);
            Map(x => x.TotalHours);
            HasMany(x => x.Lines).Cascade.All();
        }
    }
}