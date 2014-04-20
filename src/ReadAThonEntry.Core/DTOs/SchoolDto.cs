using System.Collections.Generic;

namespace ReadAThonEntry.Core.DTOs
{
    using FluentNHibernate.Data;
 
    public class SchoolDto : Entity
    { 
        public virtual string Name { get; set; }
        public virtual IList<ContactDto> Contacts { get; set; }
        public virtual string Address1 { get; set; }
        public virtual string Address2 { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Zip { get; set; }
        public virtual string Phone { get; set; }
        public virtual int NumberOfClassrooms { get; set; }

  
    }
}