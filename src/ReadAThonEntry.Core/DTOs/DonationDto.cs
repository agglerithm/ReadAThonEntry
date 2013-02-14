namespace ReadAThonEntry.DTOs
{
    using FluentNHibernate.Data;

    public class DonationDto : Entity
    { 
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual string Email { get; set; }
        public virtual string Address1 { get; set; }
        public virtual string Address2 { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Zip { get; set; }  

    }
}