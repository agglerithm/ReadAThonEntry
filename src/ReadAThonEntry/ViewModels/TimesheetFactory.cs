namespace TimeKeeper.ViewModels
{
    using System;
    using System.Linq;
    using DTOs;
    using ReadAThonEntry.DTOs;
    using ReadAThonEntry.ViewModels;
    using Repositories;

    public class TimesheetFactory : ITimesheetFactory
    {
        private ITimeBlockRepository _timeBlockRepo;

        public TimesheetFactory(ITimeBlockRepository timeBlockRepo)
        {
            _timeBlockRepo = timeBlockRepo;
        }

        public Timesheet Create(PayPeriod period)
        {
            var sheet = new Timesheet()
                            {
                                Period = period
                            };
            sheet.Times =
                _timeBlockRepo.Query(t => t.StartTime > period.StartDate && t.StartTime < period.EndDate.AddDays(1)).Select(
                    dto => createBlock(dto)).ToList();

            return sheet;
        }

        private TimeBlock createBlock(ReaderDto dto)
        {
            return new TimeBlock()
                       {
                           Comments = dto.Comments,
                           Department = dto.Department.Name,
                           StartTime = dto.StartTime,
                           EndTime = dto.EndTime
                       };
        }
    }
}