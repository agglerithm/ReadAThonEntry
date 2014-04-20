using ReadAThonEntry.Core.DTOs;

namespace ReadAThonEntry.Core
{
    public class StudentPackage
    {
        public StudentDto student { get; set; }
        public SchoolDto school { get; set; }
        public ContactDto teacher { get; set; } 
    }
}