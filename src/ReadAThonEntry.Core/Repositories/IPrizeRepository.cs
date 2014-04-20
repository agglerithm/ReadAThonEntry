using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ReadAThonEntry.Core.DTOs;

namespace ReadAThonEntry.Core.Repositories
{
    public interface IPrizeRepository
    {
        IEnumerable<PrizeDto> Query(Expression<Func<PrizeDto, bool>> where);

        PrizeDto Find(Predicate<PrizeDto> @where);

        void Save(PrizeDto student);

        void WithinUpdateContext(Action action);

        IEnumerable<PrizeDto> GetAll();
    }
}