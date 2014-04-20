using FluentNHibernate.Data;

namespace ReadAThonEntry.Core.DTOs
{
    public class PrizeDto : Entity
    { 
        public virtual decimal MinAmount { get; set; }
        public virtual decimal MaxAmount { get; set; }
        public virtual string Description { get; set; }
    }
}