namespace ReadAThonEntry.Core.DTOs
{
    using FluentNHibernate.Data;

    public class SchoolDto : Entity
    { 
        public virtual string Name { get; set; }

 
    }
}