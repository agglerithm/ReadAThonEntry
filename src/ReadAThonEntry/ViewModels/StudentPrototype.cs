namespace ReadAThonEntry.ViewModels
{
 
    public class StudentPrototype
    { 
        public string EnvelopeNumber { get; set; }
        public string Grade { get; set; }
        public string Teacher { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string School { get; set; }
        public string MinutesRead { get; set; }
        public string PagesRead { get; set; }
        public string ReadingGoal { get; set; }
        public string Comments { get; set; }
        public string ShirtSize { get; set; }
        public string AmountFromWebsite { get; set; }
        public string AmountFromEnvelope { get; set; }
        public string FundraisingGoal { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string ValidationErrorMsgs { get; set; }

        public bool CreateNewSchool
        { get; set; }

        public string GetSelected(string size)
        {
            return size == ShirtSize ? "selected" : "";
        }
    }
}