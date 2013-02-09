namespace ReadAThonEntry.DTOs
{
    using System;
    using FluentNHibernate.Data;

    public class SchoolDto : Entity
    { 
        public virtual string Name { get; set; }

 
    }
}