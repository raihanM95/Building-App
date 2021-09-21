using Building.Domain.DTOs;
using Building.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.BLL.IServices
{
    public interface IReadingService
    {
        Task<IReadOnlyList<Reading>> GetAllAsync();
        Task<IReadOnlyList<Reading>> GetAllFilteredAsync(ReadingDto readingDto);
    }
}
