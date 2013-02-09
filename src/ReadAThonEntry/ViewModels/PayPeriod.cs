namespace TimeKeeper.ViewModels
{
    using System;
    using ReadAThonEntry;

    public class PayPeriod
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public static PayPeriod GetCurrent()
        {
            return new PayPeriod()
                       {
                           StartDate = DateTime.Today.FirstDayOfMonth(),
                           EndDate = DateTime.Today.LastDayOfMonth(),


                       };
        }
    }
}