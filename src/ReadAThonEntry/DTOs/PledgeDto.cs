namespace ReadAThonEntry.DTOs
{
    using FluentNHibernate.Data;

    public class PledgeDto : Entity
    {
   

        public PledgeDto()
        { 
        } 
        public virtual string Name { get; set; }
        public virtual decimal Pledge { get; set; }
        public virtual int Minutes { get; set; }

//        public decimal GetAmount()
//        {
//            return Pledge*Minutes;
//        }
    }
}