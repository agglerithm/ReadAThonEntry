namespace ReadAThonEntry.Core.DTOs
{
    using FluentNHibernate.Data;

    public class StudentDto  : Entity
    {  
        public virtual string EnvelopeNumber { get; set; }
        public virtual string Grade { get; set; }
        public virtual string Teacher { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string School { get; set; } 
        public virtual int MinutesRead { get; set; }
        public virtual int PagesRead { get; set; }
        public virtual int ReadingGoal { get; set; }
        public virtual decimal FundraisingGoal { get; set; }
        public virtual string Comments { get; set; }            
        public virtual string ShirtSize { get; set; }
        public virtual decimal AmountFromWebsite { get; set; }
        public virtual decimal AmountFromEnvelope { get; set; }
        public virtual string Address1 { get; set; }
        public virtual string Address2 { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Zip { get; set; }
        public virtual string Phone { get; set; }

        public virtual int YearOf
        {
            get; set;
        }


//        public decimal GetTotalAmount()
//        {
//            return Pledges.Sum(p => p.GetAmount());
//        }
    }
}