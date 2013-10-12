namespace ReadAThonEntry.Services
{
    using System;
    using ReadAThonEntry.DTOs;
    using TimeKeeper.Repositories;

    public interface IInvoiceGenerator
    {
        PledgeDto Create(DateTime start, DateTime end);
    }

    public class InvoiceGenerator : IInvoiceGenerator
    {
        private readonly ITimeBlockRepository _timeRepo;

        public InvoiceGenerator(ITimeBlockRepository timeRepo)
        {
            _timeRepo = timeRepo;
        }

        public PledgeDto Create(DateTime start, DateTime end)
        {
            var times = _timeRepo.Query(t => t.State == "");

            return new PledgeDto();
        }
    }
}
