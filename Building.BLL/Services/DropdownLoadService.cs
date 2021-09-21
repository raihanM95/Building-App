using Building.BLL.IServices;
using Building.DAL;
using Building.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.BLL.Services
{
    public class DropdownLoadService : IDropdownLoadService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DropdownLoadService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IReadOnlyList<Domain.Entities.Building>> GetBuildingDropdownDataAsync()
        {
            return _unitOfWork.BuildingRepository.GetAllAsync();
        }

        public Task<IReadOnlyList<DataField>> GetDataFieldDropdownDataAsync()
        {
            return _unitOfWork.DataFieldRepository.GetAllAsync();
        }

        public Task<IReadOnlyList<Domain.Entities.Object>> GetObjectDropdownDataAsync()
        {
            return _unitOfWork.ObjectRepository.GetAllAsync();
        }
    }
}
