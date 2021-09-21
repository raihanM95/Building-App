using Entity = Building.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.BLL.IServices
{
    public interface IDropdownLoadService
    {
        Task<IReadOnlyList<Entity.Building>> GetBuildingDropdownDataAsync();
        Task<IReadOnlyList<Entity.DataField>> GetDataFieldDropdownDataAsync();
        Task<IReadOnlyList<Entity.Object>> GetObjectDropdownDataAsync();
    }
}
