namespace ReadAThonEntry.ViewModels
{
    using System;
    using System.Collections.Generic;
    using TimeKeeper.ViewModels;

    public class Invoice
    {
        public Invoice( )
        { 
        }

        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalHours { get; set; }
        public IEnumerable<InvoiceLine> Lines { get; set; }
    }
}