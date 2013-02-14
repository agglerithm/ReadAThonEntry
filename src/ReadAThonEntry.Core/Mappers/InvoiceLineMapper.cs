namespace TimeKeeper.Mappers
{
    using DTOs;
    using FluentNHibernate.Mapping;

    public class InvoiceLineMapper : ClassMap<InvoiceLineDto>
    {
        public InvoiceLineMapper()
        {
            Table("InvoiceLines");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.Amount);
            Map(x => x.Hours);
            References(x => x.Department).Column("Dept_Id"); 
        }
    }
}