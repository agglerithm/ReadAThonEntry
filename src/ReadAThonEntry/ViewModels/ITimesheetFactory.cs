namespace TimeKeeper.ViewModels
{
    using System;
    using ReadAThonEntry.ViewModels;

    public interface ITimesheetFactory
    {
        Timesheet Create(PayPeriod period);
    }
}