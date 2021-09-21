using Building.BLL.IServices;
using Building.DAL;
using Building.Domain.DTOs;
using Building.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.BLL.Services
{
    public class ReadingService : IReadingService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReadingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IReadOnlyList<Reading>> GetAllAsync()
        {
            return _unitOfWork.ReadingRepository.GetAllAsync();
        }

        public Task<IReadOnlyList<Reading>> GetAllFilteredAsync(ReadingDto readingDto)
        {
            return _unitOfWork.ReadingRepository.GetAllFilteredAsync(readingDto);
        }
    }
}
