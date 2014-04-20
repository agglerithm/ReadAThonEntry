using System.Collections.Generic;
using System.Web.Mvc;
using ReadAThonEntry.Core.DTOs;

namespace ReadAThonEntry.Core.Repositories
{
    public interface ITitleRepository
    {
        TitleDto Find(string name);
        TitleDto Insert(string title);
        IEnumerable<TitleDto> GetAll();
    }
}