namespace ReadAThonEntryMvc.Models
{
    public class StudentSearchCriteria
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public School School { get; set; }
        public bool SchoolDoesNotExist { get; set; }
        public string SchoolName { get { return School.Name; } }
        public long SchoolId { get { return School.Id; } }
    }
}