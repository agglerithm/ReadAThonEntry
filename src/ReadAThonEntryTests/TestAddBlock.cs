namespace ReadAThonEntryTests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    using ReadAThonEntry.DTOs;

    public class TestAddBlock
    {
        [Test]
        public void can_add_time_block()
        {
            var inv = new PledgeDto( );

            var line = inv.Lines.First();

            line.Hours.ShouldEqual(6.75m);
        }

        private IEnumerable<ReaderDto> getBlocks()
        {
            return new List<ReaderDto>
                       {
                           new ReaderDto()
                               {
                                   Department = new SchoolDto() {Name = "Fund Raising", Rate = 15},
                                   StartTime = DateTime.Parse("11/8/2012 13:00"),
                                   EndTime = DateTime.Parse("11/8/2012 14:15")
                               },
                           new ReaderDto()
                               {
                                   Department = new SchoolDto() {Name = "Fund Raising", Rate = 15},
                                   StartTime = DateTime.Parse("11/9/2012 10:30"),
                                   EndTime = DateTime.Parse("11/9/2012 16:00")
                               } 
                       };
        }
    }
}