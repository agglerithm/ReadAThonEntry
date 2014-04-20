using System.Collections.Generic;
using FluentNHibernate.Data;

namespace ReadAThonEntry.Core.DTOs
{
    public class ContactDto : Entity
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Title { get; set; } 
        public virtual string ShirtSize { get; set; }
        public virtual IList<StudentDto> Students { get; set; }
 
    }
}