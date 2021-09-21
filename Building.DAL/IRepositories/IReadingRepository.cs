using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Building.Domain.DTOs;
using Building.Domain.Entities;

namespace Building.DAL.IRepositories
{
    public interface IReadingRepository : IBaseRepository<Reading>
    {
        Task<IReadOnlyList<Reading>> GetAllFilteredAsync(ReadingDto readingDto);
    }
}
