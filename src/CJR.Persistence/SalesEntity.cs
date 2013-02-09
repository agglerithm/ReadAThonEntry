using System;
using FluentNHibernate.Data;

namespace ReportingRepositories.Entities
{
    public class SalesEntity :Entity
    {
        [CompositeId]
        public virtual string Location { get; set; }
        [CompositeId]
        public virtual string Warehouse { get; set; }
        [CompositeId]
        public virtual DateTime? Date { get; set; }
        public virtual decimal Sales { get; set; }
    }
}
