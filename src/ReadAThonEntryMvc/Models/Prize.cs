namespace ReadAThonEntryMvc.Models
{
    public class Prize
    {
        public long Id { get; set; }
        public decimal MinAmount { get; set; }
        public decimal MaxAmount { get; set; }
        public string Description { get; set; }
    }

}