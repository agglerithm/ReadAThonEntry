using FluentNHibernate.Data;

namespace ReadAThonEntry.Core.DTOs
{
    public class TitleDto : Entity
    {
        public virtual string TitleName { get; set; }
    }
}