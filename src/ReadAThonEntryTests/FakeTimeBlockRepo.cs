namespace ReadAThonEntryTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using ReadAThonEntry.DTOs;
    using TimeKeeper.Repositories;

    public class FakeTimeBlockRepo : ITimeBlockRepository
    {
        private IEnumerable<ReaderDto> getList()
        {
            return new List<ReaderDto>
                       {
                           new ReaderDto()
                               { 
                               },
                           new ReaderDto()
                               { 
                               },
                           new ReaderDto()
                               { 
                               } 
                       };
        }

        public IEnumerable<ReaderDto> Query(Expression<Func<ReaderDto, bool>> where)
        {
            return getList();
        }

        public ReaderDto Find(Expression<Func<ReaderDto, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Save(ReaderDto dept)
        {
            throw new NotImplementedException();
        }
    }
}