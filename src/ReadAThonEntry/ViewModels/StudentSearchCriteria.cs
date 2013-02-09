namespace ReadAThonEntry.ViewModels
{
    public class StudentSearchCriteria
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string School { get; set; }
        public bool SchoolDoesNotExist { get; set; }
    }
}