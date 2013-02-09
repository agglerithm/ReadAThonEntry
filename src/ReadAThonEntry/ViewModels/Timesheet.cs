namespace ReadAThonEntry.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;
    using TimeKeeper.ViewModels;

    public class Timesheet
    {
        public PayPeriod Period { get; set; }
        public List<TimeBlock> Times { get; set; }

        public object GetTotal()
        {
            return Times.Sum(t => t.Hours());
        }
    }
}